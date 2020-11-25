using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanalyers
{
    /// <summary>
    /// Fingerprint specific Scanalyzer
    /// </summary>
    public class PrintScanalyzer : Scanalyzer
    {
        /* **************************** Constructors **************************** */

        public PrintScanalyzer(int rows, int columns, int cluesNum) : base(rows, columns, cluesNum) { }
        public PrintScanalyzer(int rows, int columns, Clue[] clues) : base(rows, columns, clues) { }

        /* **************************** Properties **************************** */

        public override string CaseInformation => $"{base.CaseInformation} It appears that the suspect has left" +
            $" some fingerprints at the scene of the murder. Use the digital fingerprint scanner we have embedded " +
            $"in your tablet. Find some fingerprints as quickly as you can, Detective. We cannot let the suspect escape.";

        public override Image ClueImage => Resource1.fingerprint;

        public override string GetResults => "Mission Accomplished, Detective. We sent the fingerprints back to the lab " +
            "and the results should be back shortly. Thanks to you, we are able to track the suspect using his fingerprints.";

        /* **************************** Methods **************************** */

        public override Image GetRandomGridBackground()
        {
            Random rand = new Random();
            int i = rand.Next(0, 4);
            switch (i)
            {
                case 0:
                    return Resource1.room1;
                case 1:
                    return Resource1.room2;
                case 2:
                    return Resource1.room3;
                default:
                    return Resource1.room4;
            }
        }


    }
}
