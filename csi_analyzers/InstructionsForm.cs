using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csi_analyzers
{
    /// <summary>
    /// Contains instructions on how to play the game
    /// </summary>
    public partial class InstructionsForm : Form
    {
        /* **************************** Member Data **************************** */

        private SoundControl soundControl;
        private Func<Task> onCloseLambda;   // lambda from Main Menu to avoid flicker

        /* **************************** Constructors **************************** */

        public InstructionsForm(Func<Task> onCloseLambda)
        {
            InitializeComponent();
            InitViews();

            soundControl = SoundControl.Instance;
            this.onCloseLambda = onCloseLambda;
        }

        /* **************************** Methods **************************** */

        /// <summary>
        /// Initialize Controls
        /// </summary>
        private void InitViews()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Utilities.SetDoubleBuffering(Controls, true);
            instructionsGroupBox.BackColor = Color.FromArgb(30, Constants.PRIMARY_COLOR);
            instructionsLabel.BackColor = Color.Transparent;
        }

        /* **************************** Event Handlers **************************** */

        async private void okButton_Click(object sender, EventArgs e)
        {
            // show main form before closing this form to prevent flickers
            soundControl.PlayEffect(SoundControl.SoundType.DefaultEffect);
            await onCloseLambda();
            Close();
        }

        async private void InstructionsForm_Load(object sender, EventArgs e)
        {
            // animate test
            foreach(char c in Constants.INSTRUCTIONS)
            {
                
                await Task.Delay(40);
                instructionsLabel.Text += c;
                if (c == '.' || c == ',')
                {
                    await Task.Delay(250);
                }
            }
        }

        private void okButton_OnMouseEnter(object sender, EventArgs e)
        {
            soundControl.PlayEffect(SoundControl.SoundType.HoverEffect);
            okButton.ForeColor = Constants.PRIMARY_COLOR;
        }

        private void okButton_OnMouseLeave(object sender, EventArgs e)
        {
            okButton.ForeColor = Constants.SECONDARY_COLOR;
        }

       
    }

}
