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
    /// Form Shown before loading
    /// </summary>
    public partial class EvidenceTypeForm : Form
    {
        /* **************************** Member Data **************************** */

        private SoundControl soundControl;

        /* **************************** Constructors **************************** */

        public EvidenceTypeForm()
        {
            InitializeComponent();
            soundControl = SoundControl.Instance;
            InitViews();
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
        }

        /* **************************** Event Handlers **************************** */

         /// <summary>
         /// Handle all button clicks
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void buttons_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm;

            // set game type
            if (sender == fingerprintsButton)
            {
                loadingForm = new LoadingForm(Settings.GameType.Fingerprint);
            }
            else if (sender == DNAButton)
            {
                loadingForm = new LoadingForm(Settings.GameType.DNA);
            }
            else
            {
                loadingForm = new LoadingForm(Settings.GameType.Blood);
            }
            
            // navigate to LoadingForm
            loadingForm.Show();
            loadingForm.Shown += async (sender1, e1) => { await Task.Delay(150); Close(); };

        }

        private void buttons_MouseEnter(object sender, EventArgs e)
        {
            soundControl.PlayEffect(SoundControl.SoundType.HoverEffect);
            ((Button)sender).ForeColor = Constants.PRIMARY_COLOR;
        }

        private void buttons_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Constants.SECONDARY_COLOR;
        }

    }
}
