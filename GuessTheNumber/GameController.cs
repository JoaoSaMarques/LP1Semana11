using System;

namespace GuessTheNumber
{
    public class GameController
    {
        //Game model
        private readonly GameModel gameModel;
        //Game view
        private readonly GameView gameView;

        /// <summary>
        /// will be used for main and build the project
        /// </summary>
        public GameController()
        {
            gameModel = new GameModel();
            gameView = new GameView();
        }

        /// <summary>
        /// Main game loop
        /// </summary>
        public void StartGame()
        {
            //We'll be used in another class to display beginning portion
            gameView.DisplayWelcomeMessage();

            //loop
            while (!gameModel.GuessedCorrectly)
            {
                //Display hot or cold
                gameView.DisplayGuessPrompt();
                //Every time the player types a number to guess
                int guess = gameView.GetPlayerGuess();
            }
    }
}