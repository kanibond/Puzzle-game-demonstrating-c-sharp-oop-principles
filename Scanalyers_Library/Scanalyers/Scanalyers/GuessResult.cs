using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Scanalyers
{
    /// <summary>
    /// Represents the result of 1 guess
    /// </summary>
    public class GuessResult
    {
        /* **************************** Constructors **************************** */

        public GuessResult(bool isCorrect, Image image)
        {
            IsCorrect = isCorrect;
            Image = image;
        }

        /* **************************** Properties **************************** */

        public Image Image { get; set; }
        public bool IsCorrect { get; set; }
    }
}
