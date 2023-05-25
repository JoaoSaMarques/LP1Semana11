using System;

namespace GuessTheNumber
{
    public class GameController
    {
        //Game model
        private readonly GameModel gameModel;
        //Game view
        private readonly GameView gameView;

        //will be used for main and build the project
        public GameController()
        {
            gameModel = new GameModel();
            gameView = new GameView();
        }
    }
}