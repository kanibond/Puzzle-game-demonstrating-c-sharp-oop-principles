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
    /// Custom Button
    /// Buttons that are a part of the Game Grid
    /// </summary>
    public partial class GridButton : Button
    {
        /* **************************** Member Data **************************** */

        const int START_X = 0;
        const int START_Y = 0;
        const int BUTTON_SIZE_X = 30;

        /* **************************** Constructors **************************** */

        public GridButton(int row, int column, int sizeX, int sizeY) : base()
        {
            InitializeComponent();

            // set size
            Size = new Size(sizeY, sizeX);

            // set flat appearance properties
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.CornflowerBlue;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.FromArgb(50, Color.CornflowerBlue);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(90, Color.CornflowerBlue);

            // calculate postion of the button
            Top = START_X + row * Height;
            Left = START_Y + column * Width;
            Row = row;
            Column = column;
            IsClue = false;
            Tag = $"{row},{column}";
        }

        /* **************************** Properties **************************** */

        public int Row { get; private set; }
        public int Column { get; private set; }
        public bool IsClue { get; set; }

        /* **************************** Methods **************************** */

        public void clearImage()
        {
            Image = null;
        }

        /* **************************** Event Handlers **************************** */

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


    }
}
