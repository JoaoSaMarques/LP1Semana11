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

        /// <summary>
        /// Guess the number that was randomly generated
        /// </summary>
        public void DisplayGuessPrompt()
        {
            Console.Write("Take a guess: ");
        }

        /// <summary>
        /// Convert player's string into a readable int for program.
        /// </summary>
        /// <returns></returns>
        public int GetPlayerGuess()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// If player succeeded, this will display the number of attempts.
        /// </summary>
        /// <param name="attempts"></param>
        public void DisplaySuccessMessage(int attempts)
        {
            Console.WriteLine("Congratulations! You guessed the number right!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        /// <summary>
        /// If the number is either 
        /// too low it'll be cold, if it's too high it'll be hot
        /// </summary>
        /// <param name="isTooLow"></param>
        public void DisplayHint(bool isTooLow)
        {
            if (isTooLow)
                Console.WriteLine("Too low! Try again.");
            else
                Console.WriteLine("Too high! Try again.");
        }

        /// <summary>
        /// After you finish the game it'll display this message
        /// </summary>
        public void DisplayExitMessage()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}