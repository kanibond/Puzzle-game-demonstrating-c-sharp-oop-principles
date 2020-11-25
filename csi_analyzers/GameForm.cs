using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scanalyers;

namespace csi_analyzers
{
    /// <summary>
    /// Main Game Form
    /// </summary>
    public partial class GameForm : Form
    {
        /* **************************** Member Data **************************** */
        private GridButton[,] gridButtons;
        private SoundControl soundControl;
        private readonly int totalAllowedTime;
        private int timeRemaining;
        private readonly int cluesNum;
        private Settings.GameType type;
        private Scanalyzer scanalyzer;
        private bool cancelled;

        /* **************************** Constructors **************************** */

        public GameForm(GridButton[,] gridButtons, Settings.GameType type, int cluesNum)
        {
            InitializeComponent();
            soundControl = SoundControl.Instance;
            this.gridButtons = gridButtons;
            this.type = type;
            cancelled = false;
            this.cluesNum = cluesNum;
            timeRemaining = totalAllowedTime = 194;
            InitScanalyzer();
            InitViews();
        }

        public GameForm(GridButton[,] gridButtons, Settings.GameType type, int cluesNum, Clue[] clues)
        {
            InitializeComponent();
            soundControl = SoundControl.Instance;
            this.gridButtons = gridButtons;
            this.type = type;
            this.cluesNum = cluesNum;
            timeRemaining = totalAllowedTime = 194;
            InitScanalyzer(clues);
            InitViews();
        }

        /* **************************** Methods **************************** */

        /// <summary>
        /// Instantaites the Scanalyzer dynamically
        /// </summary>
        private void InitScanalyzer()
        {
            switch (type)
            {
                case Settings.GameType.Fingerprint:
                    scanalyzer = new PrintScanalyzer(gridButtons.GetLength(0), gridButtons.GetLength(1), cluesNum);
                    break;
                case Settings.GameType.DNA:
                    scanalyzer = new DNAScanalyzer(gridButtons.GetLength(0), gridButtons.GetLength(1), cluesNum);
                    break;
                default:
                    scanalyzer = new BloodScanalyzer(gridButtons.GetLength(0), gridButtons.GetLength(1), cluesNum);
                    break;
            }
        }

        /// <summary>
        /// Instantiates the Scanalyzer dynamically with already set clues
        /// </summary>
        /// <param name="clues"></param>
        private void InitScanalyzer(Clue[] clues)
        {
            switch (type)
            {
                case Settings.GameType.Fingerprint:
                    scanalyzer = new PrintScanalyzer(gridButtons.GetLength(0), gridButtons.GetLength(1), clues);
                    break;
                case Settings.GameType.DNA:
                    scanalyzer = new DNAScanalyzer(gridButtons.GetLength(0), gridButtons.GetLength(1), clues);
                    break;
                default:
                    scanalyzer = new BloodScanalyzer(gridButtons.GetLength(0), gridButtons.GetLength(1), clues);
                    break;
            }
        }

        /// <summary>
        /// Initializes Controls
        /// </summary>
        private void InitViews()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            foreach (GridButton button in gridButtons)
            {
                panel.Controls.Add(button);
                button.Click += GridButtons_Click;
            }
            guessesLabel.Text = "0";
            cluesFoundLabel.Text = $"0/{cluesNum}";
            caseInformationLabel.Text = scanalyzer.CaseInformation;
            panel.BackgroundImage = scanalyzer.GetRandomGridBackground();

            if (Settings.Instance.CanImport)
                caseInformation.Text = Settings.Instance.ImportedScenesPath;
            else
                caseInformation.Text = $"Officer {Utilities.GetRandomOfficerName()} Murder Scene";

            Utilities.SetDoubleBuffering(Controls, true);

            
        }

        /// <summary>
        /// Removes images from buttons after correct guess.
        /// </summary>
        private void ResetButtonsAfterCorrectGuess()
        {
            foreach (GridButton button in gridButtons)
            {
                if (!button.IsClue)
                    button.clearImage();
            }
        }

        /// <summary>
        /// Ends the game after winning
        /// </summary>
        private void FinishGame()
        {
            string message = $"{scanalyzer.GetResults}";
            timerBackgroundWorker.CancelAsync();
            cancelled = true;

            // Add more information for specific types of scanalyzers
            if (scanalyzer is BloodScanalyzer)
                message = $"{message} {((BloodScanalyzer)scanalyzer).BloodType}";

            if (scanalyzer is DNAScanalyzer)
                message = $"{message} {((DNAScanalyzer)scanalyzer).DNAMatchPercentage}";

            DialogResult result = MessageBox.Show($"{message} Would you like to restart?",
                                                 "Success",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Information);
            switch(result)
            {
                case DialogResult.Yes:
                    RestartGame();
                    break;
                default:
                    AbortGame();
                    break;
            }
        }

        /// <summary>
        /// Reveals all clue locations
        /// </summary>
        private void RevealClues()
        {
            Clue[] clues = scanalyzer.RevealClues();
            foreach(GridButton button in gridButtons)
            {
                foreach(Clue clue in clues)
                {
                    if ((string)button.Tag == $"{clue.Row},{clue.Column}")
                        button.Image = scanalyzer.ClueImage;
                }
            }
        }

        /* **************************** Event Handlers **************************** */

        async private void GameForm_Load(object sender, EventArgs e)
        {
            soundControl.PlayTheme(SoundControl.SoundType.InGameTheme);
            Console.WriteLine(panel.Size);
            await Task.Delay(1000);
            timerBackgroundWorker.RunWorkerAsync();
        }

        // Background timer
        private void timerBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < totalAllowedTime; i++)
            {
                // Sleep background thread (blocking sleep). Did not use await Task.Delay()
                // because async await cannot be used with a background worker => exit point for thread
                // it's okay to use blocking sleep with a thread as long as it's not a GUI thread
                if (timerBackgroundWorker.CancellationPending)
                    return;

                System.Threading.Thread.Sleep(1000);    
                timeRemaining--;
                timerBackgroundWorker.ReportProgress(i * 100 / totalAllowedTime);
            }
        }

        /// <summary>
        /// Updates labels every second
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int minutes = timeRemaining / 60;
            int seconds = timeRemaining % 60;
            string secondsStr = seconds < 10 ? $"0{seconds}" : seconds.ToString();

            timeLeftLabel.Text = $"{minutes}:{secondsStr}";
            timerProgressBar.Value = 100 - e.ProgressPercentage;

            if (minutes < 1)
            {
                timeLeftLabel.ForeColor = Color.Red;
                hurryLabel.Show();

                if (seconds < 20)
                    hurryLabel.ForeColor =  timeLeftLabel.ForeColor = seconds % 2 == 0 ? Color.Red : Color.White;
            }

        }

        /// <summary>
        /// Ends timer after losing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBackgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!cancelled)
            {
                timerProgressBar.Value = 0;
                ResetButtonsAfterCorrectGuess();
                RevealClues();
                DialogResult result = MessageBox.Show(Constants.YOU_FAILED,
                                                     Constants.MISSION_FAILED,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        RestartGame();
                        break;
                    default:
                        AbortGame();
                        break;
                }
            }
        }

        private void button_OnMouseEnter(object sender, EventArgs e)
        {
            soundControl.PlayEffect(SoundControl.SoundType.HoverEffect);
            ((Button)sender).ForeColor = Constants.PRIMARY_COLOR;
        }

        private void button_OnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = sender == abortButton ? Color.Red : Constants.SECONDARY_COLOR;
        }

        /// <summary>
        /// Handle Buttons that exit and restart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuButtons_Click(object sender, EventArgs e)
        {
            ResetButtonsAfterCorrectGuess();
            cancelled = true;
            timerBackgroundWorker.CancelAsync();
            RevealClues();
            MessageBox.Show("You failed Gotham City.", Constants.MISSION_FAILED, MessageBoxButtons.OK);
            if (sender == abortButton)
                AbortGame();
            else
                RestartGame();

        }

        /// <summary>
        /// Exits game session
        /// </summary>
        async private void AbortGame()
        {
            MainMenuForm form = (MainMenuForm)Application.OpenForms["MainMenuForm"];
            form.Show();
            await Task.Delay(200);
            soundControl.PlayTheme(SoundControl.SoundType.MainTheme);
            Close();
        }

        async private void RestartGame()
        {
            LoadingForm form = new LoadingForm(type);
            soundControl.StopTheme();
            form.Show();
            await Task.Delay(200);
            Close();
        }

        /// <summary>
        /// Submits guess and checks if the game is finished
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridButtons_Click(object sender, EventArgs e)
        {
            GridButton button = (GridButton)sender;

            // if button has not already been revealed to have a clue
            if (!button.IsClue)
            {
                // evaluate guess and update images
                GuessResult result = scanalyzer.EvaluateGuess(new Clue(button.Row, button.Column));
                button.Image = result.Image;
                guessesLabel.Text = scanalyzer.Guesses.ToString();
                cluesFoundLabel.Text = $"{scanalyzer.CurrentSample}/{cluesNum}";

                if (result.IsCorrect)
                {
                    button.IsClue = true;
                    ResetButtonsAfterCorrectGuess();
                    if (scanalyzer.AllCluesFound())
                        FinishGame();
                }
            }
                   
        } 
    }
}
