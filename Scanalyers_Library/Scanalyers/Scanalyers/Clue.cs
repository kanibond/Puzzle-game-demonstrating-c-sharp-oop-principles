using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanalyers
{
    /// <summary>
    /// Class that represents 1 clue
    /// </summary>
    public class Clue
    {

        /* **************************** Constructors **************************** */

        public Clue()
        {
            Row = Column = 0;
        }

        public Clue(int x, int y)
        {
            Row = x;
            Column = y;
            Found = false;
        }

        public Clue(Clue clue)
        {
            Row = clue.Row;
            Column = clue.Column;
            Found = clue.Found;
        }

        /* **************************** Properties **************************** */

        public int Row { get; }

        public int Column { get; }

        public bool Found { get; set; }

        /* **************************** Methods **************************** */

        /// <summary>
        /// Override Equals To supress warnings
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool</returns>
        public override bool Equals(object obj)
        {
            Clue a = (Clue)obj;
            return Row == a.Row && Column == a.Column;
        }

        /// <summary>
        /// Override GetHashCode to supress warnings
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Formats point to a string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"({Row}, {Column})";
        }

        /******************** Overloaded Operators ********************/

        /// <summary>
        /// Overloaded operator ==
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool</returns>
        public static bool operator ==(Clue left, Clue right)
        {
            if (((object)left) == null && ((object)right) == null) return true;
            if (((object)left) == null || ((object)right) == null) return false;
            return left.Row == right.Row && left.Column == right.Column;
        }

        /// <summary>
        /// Overloaded operator !=
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool</returns>
        public static bool operator !=(Clue left, Clue right)
        {
            if (((object)left) == null && ((object)right) == null) return false;
            if (((object)left) == null || ((object)right) == null) return true;
            return left.Row != right.Row || left.Column != right.Column;
        }
    }
}

