/**
 * Shady Boukhary
 * Dr. Stringfellow
 * Contemporary Programming Languages: C#
 * October 20th, 2018
 * Description: Full CSI Puzzle Game. The user can choose multiple difficulties.
 * The game includes a grid of buttons and the user has to search for clues by
 * clicking on the buttons. Hints are given as to where the clues are located.
 * A timer exists that adds more challenge as well as a variety of settings to 
 * customize the game.
 *
 * */

using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace csi_analyzers
{
    /// <summary>
    /// Main Menu Form
    /// First Form in the app
    /// </summary>
    public partial class MainMenuForm : Form
    {
        /* **************************** Member Data **************************** */

        private SoundPlayer Player = new SoundPlayer();
        private SoundControl soundControl;
        private Func<Task> formClosedEventHandler;

        /* **************************** Constructors **************************** */

        public MainMenuForm()
        {
            InitializeComponent();
            soundControl = SoundControl.Instance;
            // Back Button lambda
            formClosedEventHandler = async () => { Show();  await Task.Delay(100); };
            Utilities.SetDoubleBuffering(Controls, true);
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            initViews();
            
            
        }

        /// <summary>
        /// Initailize Controls
        /// </summary>
        private void initViews()
        {
            playButton.BackColor = Color.FromArgb(0, Color.DarkBlue);
            playButton.ForeColor = Color.FromArgb(100, Constants.PRIMARY_COLOR);
            instructionsButton.BackColor = Color.FromArgb(0, Color.DarkBlue);
            instructionsButton.ForeColor = Color.FromArgb(100, Constants.PRIMARY_COLOR);
            settingsButton.BackColor = Color.FromArgb(0, Color.DarkBlue);
            settingsButton.ForeColor = Color.FromArgb(100, Constants.PRIMARY_COLOR);

            exitButton.BackColor = Color.FromArgb(0, Color.DarkBlue);
            exitButton.ForeColor = Color.FromArgb(100, Constants.PRIMARY_COLOR);

            mainMenuGroupBox.BackColor = Color.FromArgb(30, Constants.PRIMARY_COLOR);
        }

        /* **************************** Event Handlers **************************** */

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            soundControl.PlayTheme(SoundControl.SoundType.MainTheme);
        }


        private void buttons_OnMouseEnter(object sender, EventArgs e)
        {
            soundControl.PlayEffect(SoundControl.SoundType.HoverEffect);
            ((Button)sender).ForeColor = Constants.SECONDARY_COLOR;

        }

        private void buttons_OnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Constants.PRIMARY_COLOR;
        }

        /// <summary>
        /// Handle all buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void buttons_Click(object sender, MouseEventArgs e)
        {
            if (sender == playButton)
            {
                NavigateTo(new EvidenceTypeForm());
            }
            else if (sender == instructionsButton)
            {
                NavigateTo(new InstructionsForm(formClosedEventHandler));
            }
            else if (sender == settingsButton)
            {
                NavigateTo(new SettingsForm(formClosedEventHandler));
            }
            else   // exit button
            {
                soundControl.PlayEffect(SoundControl.SoundType.CancelEffect);
                await Task.Delay(100);
                Close();
            }
        }

        /// <summary>
        /// Navigate to appropriate page
        /// </summary>
        /// <param name="form"></param>
        private void NavigateTo(Form form)
        {
            soundControl.PlayEffect(SoundControl.SoundType.DefaultEffect);
            form.Show();
            form.Shown += async (sender, e) => { await Task.Delay(150); Hide(); };

        }
    }
}
