using System;

namespace GuessTheNumber
{
    /// <summary>
    /// Model/constructor for other code
    /// </summary>
    public class GameModel
    {
        //Number player has to reach
        public int TargetNumber { get; }
        //Number of attempts made by the player
        public int Attempts { get; set; }
        //Correct guess
        public bool GuessedCorrectly { get; set; }

        /// <summary>
        /// Will be used to make random numbers between 1 and 100
        /// </summary>
        public GameModel()
        {
            //Create random number            
            Random random = new Random();
            TargetNumber = random.Next(1, 101);
            //Default attempt value
            Attempts = 0;
            //This will turn true on correct guess
            GuessedCorrectly = false;
        }
    }
}