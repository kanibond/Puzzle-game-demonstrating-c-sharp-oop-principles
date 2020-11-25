using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanalyers
{
    /// <summary>
    /// DNA Specific Scanalyzer
    /// </summary>
    public class DNAScanalyzer : BloodScanalyzer
    {
        /* **************************** Constructors **************************** */

        public DNAScanalyzer(int rows, int columns, int cluesNum) : base(rows, columns, cluesNum) { }
        public DNAScanalyzer(int rows, int columns, Clue[] clues) : base(rows, columns, clues) { }

        /* **************************** Properties **************************** */

        public override Image ClueImage => Resource1.dna;

        public string DNAMatchPercentage
        {
            get
            {
                Random rand = new Random();
                return $"The digital DNA analyzer returned a match of {rand.Next(50, 100)}% using the blood samples.";
            }
        }

        /* **************************** Methods **************************** */

        public override Image GetRandomGridBackground()
        {
            Random rand = new Random();
            int i = rand.Next(0, 3);
            switch (i)
            {
                case 0:
                    return Resource1.weapon1;
                case 1:
                    return Resource1.weapon2;                    
                default:
                    return Resource1.weapon3;
            }
        }
    }
}
