using System;

namespace GuessTheNumber
{
    /// <summary>
    /// This will be used to construct the messages written for the player
    /// </summary>
    public class GameView
    {
        /// <summary>
        /// Start message/Instructions at the start
        /// </summary>
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }
    }
}