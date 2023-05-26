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
    }
    
}