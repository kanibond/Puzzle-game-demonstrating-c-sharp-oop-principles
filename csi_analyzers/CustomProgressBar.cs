using System.Drawing;
using System.Windows.Forms;

namespace csi_analyzers
{
    /// <summary>
    /// Custom Progress Bar with Custom Colors
    /// </summary>
    public partial class CustomProgressBar : ProgressBar
    {
        private SolidBrush brush = null;

        public CustomProgressBar()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (brush == null || brush.Color != this.ForeColor)
                brush = new SolidBrush(this.ForeColor);

            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);
            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
        }
    }
}
