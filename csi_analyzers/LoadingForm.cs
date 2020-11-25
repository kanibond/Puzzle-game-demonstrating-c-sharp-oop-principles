using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Scanalyers;

namespace csi_analyzers
{
    /// <summary>
    /// Form for loading page
    /// Loads the game, grids, and reads the file if necessary
    /// </summary>
    public partial class LoadingForm : Form
    {
        /* **************************** Member Data **************************** */

        const int PANEL_MAX_WIDTH = 900;
        const int PANEL_MAX_HEIGHT = 905;
        private Settings settings;
        private Settings.GameType type;
        private GridButton[,] gridButtons;
        private int cluesNum;
        private int maxRows, maxCols;
        private bool fileError;
        private Clue[] clues;

        /* **************************** Constructors **************************** */

        public LoadingForm(Settings.GameType type)
        {
            InitializeComponent();
            InitViews();
            settings = Settings.Instance;
            this.type = type;
            fileError = false;
        }

        /// <summary>
        /// Initialize Controls
        /// </summary>
        private void InitViews()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Utilities.SetDoubleBuffering(Controls, true);
        }

        /// <summary>
        /// Set Grid Size according to difficulty setting
        /// </summary>
        /// <returns></returns>
        private Size GetGridSize()
        {
            switch (settings.Difficulty)
            {
                case Settings.GameDifficulty.Easy:
                    cluesNum = 8;
                    return Constants.GRID_EASY_SIZE;
                case Settings.GameDifficulty.Medium:
                    cluesNum = 17;
                    return Constants.GRID_MEDIUM_SIZE;
                default:
                    cluesNum = 21;
                    return Constants.GRID_HARD_SIZE;
            }
        }

        /// <summary>
        /// Read the input file
        /// </summary>
        /// <returns>Array of clues</returns>
        private Clue[] ReadFile()
        {
            StreamReader file = new StreamReader(settings.ImportedScenesPath);
            try
            {
                // read first line indicating grid sizes
                string line = file.ReadLine();
                var data = line.Split(' ');
                maxRows = Int32.Parse(data[0]);
                maxCols = Int32.Parse(data[1]);

                List<Clue> clues = new List<Clue>();

                // read the rest of the lines indicating clue locations
                while ((line = file.ReadLine()) != null)
                {
                    data = line.Split(' ');
                    int row = Int32.Parse(data[0]);
                    int column = Int32.Parse(data[1]);

                    // validate that clues are within the grid limits
                    if (row >= maxRows || column >= maxCols)
                        throw new Exception("Error Reading File: Clue locations are not within the grid.");

                    clues.Add(new Clue(row, column));
                    cluesNum++;
                }
                return clues.ToArray();
            }
            catch(Exception e)
            {
                throw e;
            }
            

        }
        /* **************************** Event Handlers **************************** */

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            loadingBackgroundWorker.RunWorkerAsync();

        }

        /// <summary>
        /// Do the loading in the background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadingBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            // read file if option is checked
            if (settings.CanImport)
            {
                try
                {
                    clues = ReadFile();
                } catch (Exception)
                {
                    // set error to true, cannot throw from background to main thread
                    fileError = true;
                    loadingBackgroundWorker.ReportProgress(100);
                }
                
            }
            else
            {
                // if no file is specified, randomly generate grid sizes
                Size gridSize = GetGridSize();
                maxRows = Utilities.GetRandomInt(gridSize.Width, gridSize.Height);
                maxCols = Utilities.GetRandomInt(gridSize.Width, gridSize.Height);
            }

            gridButtons = new GridButton[maxRows, maxCols];

            // generate GridButtons according to sizes
            for (int row = 0; row < maxRows; row++)
            {
                // to report background progress
                int rowProgress = (row + 1) * 99 / maxRows;

                for (int col = 0; col < maxCols; col++)
                {
                    int colProgress = (col + 1) * maxCols / (maxRows * maxCols);
                    gridButtons[row, col] = new GridButton(row, col, PANEL_MAX_HEIGHT / maxRows, PANEL_MAX_WIDTH / maxCols);

                    // report progress to main thread
                    int progress = rowProgress + colProgress;
                    loadingBackgroundWorker.ReportProgress(progress <= 100 ? progress : 100);
                }
            }
        }

        /// <summary>
        /// Updates progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadingBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        async private void loadingBackgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            // check for file errors
            if (!fileError)
            {
                GameForm gameForm;

                // if file was read use the clues read from the file, otherwise randomly
                if (settings.CanImport)
                    gameForm = new GameForm(gridButtons, type, cluesNum, clues);

                else
                    gameForm = new GameForm(gridButtons, type, cluesNum);

                // 1 second delay for visual purposes
                await Task.Delay(1000);
                SoundControl.Instance.StopTheme();

                // hide before navigation to reduce flicker
                progressBar.Hide();
                loadingLabel.Hide();
                gameForm.Show();

                // navigate and close
                gameForm.Shown += async (sender1, e1) => { await Task.Delay(2000); Close(); };

            }
            else 
            {
                // handle file errors and return to main menu
                MessageBox.Show("There was a problem reading the input file.", "File Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.OpenForms[0].Show();
                await Task.Delay(200);
                Close();
            }
            
        }

        private void LoadingForm_Shown(object sender, EventArgs e)
        {
            loadingBackgroundWorker.RunWorkerAsync();
        }
    }
}
