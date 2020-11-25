using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csi_analyzers
{
    /// <summary>
    /// Form For Settings Page
    /// </summary>
    public partial class SettingsForm : Form
    {
        /* **************************** Member Data **************************** */

        private readonly SoundControl soundControl;
        private readonly Settings settings;
        private Func<Task> onCloseLambda;

        private bool canImport;
        private Settings.GameDifficulty difficulty;
        private string path;
        private bool settingUp;

        /* **************************** Constructors **************************** */

        public SettingsForm(Func<Task> onCloseLambda)
        {
            InitializeComponent();
            soundControl = SoundControl.Instance;
            settings = Settings.Instance;
            this.onCloseLambda = onCloseLambda;
            settingUp = true;
            InitViews();
            RetrieveSettings();
            settingUp = false;
        }

        /* **************************** Methods **************************** */

        /// <summary>
        /// Initializes Controls
        /// </summary>
        private void InitViews()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Utilities.SetDoubleBuffering(Controls, true);
            settingsGroupBox.BackColor = Color.FromArgb(30, Constants.PRIMARY_COLOR);
            descriptionLabel.BackColor = Color.Transparent;
            importCheckBox.BackColor = Color.Transparent;
            uploadButton.Enabled = false;
        }

        /// <summary>
        /// Retrieves all settings from the Settings class
        /// </summary>
        private void RetrieveSettings()
        {
            canImport = settings.CanImport;
            difficulty = settings.Difficulty;
            path = settings.ImportedScenesPath;

            uploadButton.Enabled = importCheckBox.Checked = canImport;
            pathLabel.Text += path;

            // set difficulty buttons
            switch (difficulty)
            {
                case Settings.GameDifficulty.Easy:
                    easyRadioButton.Checked = true;
                    break;

                case Settings.GameDifficulty.Medium:
                    mediumRadioButton.Checked = true;
                    break;

                case Settings.GameDifficulty.Hard:
                    hardRadioButton.Checked = true;
                    break;
            }
        }

        private void button_OnMouseEnter(object sender, EventArgs e)
        {
            soundControl.PlayEffect(SoundControl.SoundType.HoverEffect);
            ((Button)sender).ForeColor = Constants.PRIMARY_COLOR;
        }

        private void button_OnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Constants.SECONDARY_COLOR;
        }

        private void importCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!settingUp)
            {
                canImport = !canImport;
                uploadButton.Enabled = !uploadButton.Enabled;
            }

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == easyRadioButton)
                difficulty = Settings.GameDifficulty.Easy;

            else if (sender == mediumRadioButton)
                difficulty = Settings.GameDifficulty.Medium;

            else
                difficulty = Settings.GameDifficulty.Hard;
        }

        /// <summary>
        /// Open Dialog and get file path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = Utilities.GetTextFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
                pathLabel.Text += path = dialog.FileName;
           
        }

        /// <summary>
        /// Handle buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void backButtons_Click(object sender, EventArgs e)
        {
            // show main form before closing this form to prevent flickers
            if (sender == okButton)
            {
                // save settings using Settings class
                soundControl.PlayEffect(SoundControl.SoundType.DefaultEffect);
                settings.SaveSettings(difficulty, canImport, path);
            }
            else
            {
                soundControl.PlayEffect(SoundControl.SoundType.CancelEffect);
            }

            // call lambda to avoid flickers
            await onCloseLambda();
            Close();
        }

        
    }
}
