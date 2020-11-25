using System;

using System.Drawing;

namespace Scanalyers
{
    public abstract class Scanalyzer
    {
        /* **************************** Member Data **************************** */

        private readonly int rows;
        private readonly int columns;
        private int guessCounter;
        private int currentSample;
        private Clue[] clues;

        /* **************************** Constructors **************************** */

        public Scanalyzer(int rows, int columns, int cluesNum)
        {
            this.rows = rows;
            this.columns = columns;
            guessCounter = 0;
            currentSample = 0;
            
            GenerateCluePositions(cluesNum);
        }

        public Scanalyzer(int rows, int columns, Clue[] clues)
        {
            this.rows = rows;
            this.columns = columns;
            guessCounter = 0;
            currentSample = 0;
            this.clues = clues;
        }

        /* **************************** Properties **************************** */

        public abstract Image ClueImage { get; }
        public virtual string CaseInformation => "Thank you for getting here so quickly, Detective.";
        public virtual string GetResults => $"You have succeeded, Detective! You have found {clues.Length} clues.";
        public int Guesses => guessCounter;
        public int CurrentSample => currentSample;


        /* **************************** Methods **************************** */

        public abstract Image GetRandomGridBackground();

        /// <summary>
        /// Is called when a guess is a miss. Finds the appropriate image 
        /// for the clue.
        /// </summary>
        /// <param name="guess"></param>
        /// <returns>Symbol for the clue</returns>
        public Image GetClueHint(Clue guess)
        {
            if (guessCounter % 2 == 0)
                return guess.Row > clues[currentSample].Row ? Resource1.arrow_up : Resource1.down_arrow;
            else
                return guess.Column > clues[currentSample].Column ? Resource1.left_arrow : Resource1.right_arrow;
        }

        /// <summary>
        /// Generates random positions for the clues.
        /// </summary>
        private void GenerateCluePositions(int cluesNum)
        {
            clues = new Clue[cluesNum];
            Random random = new Random();

            for (int i = 0; i < clues.Length; i++)
            {
                Clue clue = new Clue(random.Next(0, rows), random.Next(0, columns));

                while (!ValidClue(clue))
                    clue = new Clue(random.Next(0, rows), random.Next(0, columns));

                clues[i] = clue;
            }

                

        }

        /// <summary>
        /// Check whether a clue already exists in that position
        /// </summary>
        /// <param name="clue"></param>
        /// <returns></returns>
        private bool ValidClue(Clue clue)
        {
            foreach(Clue c in clues)
            {
                if (c != null && c == clue)
                    return false;
            }
            return true;
        }


        /// <summary>
        /// Checks if the guess matches the location of a clue. If yes,
        /// update counters. Updates the grid with the correct symbol
        /// and calls DisplayGrid().
        /// </summary>
        /// <param name="guess"></param>
        /// <returns></returns>
        public GuessResult EvaluateGuess(Clue guess)
        {
            guessCounter++;
            bool hit = clues[currentSample] == guess;

            if (hit)
            {
                currentSample++;
                return new GuessResult(hit, ClueImage);
            }
            else
            {
                 return new GuessResult(hit, GetClueHint(guess));
            }

        }

        /// <summary>
        /// Check whether all clues have been found
        /// </summary>
        /// <returns></returns>
        public bool AllCluesFound()
        {
            return currentSample > clues.Length - 1;
        }

        /// <summary>
        /// Return all clues
        /// </summary>
        /// <returns></returns>
        public Clue[] RevealClues()
        {
            return clues;
        }

        /// <summary>
        /// Resets the grid after all clues have been found.
        /// </summary>
        public void Reset()
        {
            currentSample = 0;
            GenerateCluePositions(clues.Length);
        }


    }
}

