using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanalyers
{
    /// <summary>
    /// BLood specific Scanalyzer
    /// </summary>
    public class BloodScanalyzer : Scanalyzer
    {
        /* **************************** Constructors **************************** */

        public BloodScanalyzer(int rows, int columns, int cluesNum) : base(rows, columns, cluesNum) { }
        public BloodScanalyzer(int rows, int columns, Clue[] clues) : base(rows, columns, clues) { }

        /* **************************** Properties **************************** */

        public override string CaseInformation => $"{base.CaseInformation} It seems like the suspect got into a fight " +
            $"with the victim. Some of that blood can definitely be the suspect's. Make haste, Detective. Find and collect blood  " +
            $"samples so they could be transported back to the lab were they will be analyzed. We cannot allow the suspect to " +
            $"get away.";

        public override Image ClueImage => Resource1.blood;

        public override string GetResults => "Mission Accomplished, Detective. We sent the blood samples back to the lab " +
            "and the results should be back shortly. Thanks to you, we are able to track the suspect using his blood samples.";

        public string BloodType
        {
            get
            {
                Random rand = new Random();
                int i = rand.Next(0, 4);
                string bloodType;

                switch (i)
                {
                    case 0:
                        bloodType = "A";
                        break;
                    case 1:
                        bloodType = "B";
                        break;
                    case 2:
                        bloodType = "AB";
                        break;
                    default:
                        bloodType = "O";
                        break;     
                }
                bloodType += i % 2 == 0 ? "-" : "+";
                return bloodType;
            }
        }

        /* **************************** Methods **************************** */

        public override Image GetRandomGridBackground()
        {
            return Resource1.weapon1;
        }
    }
}
