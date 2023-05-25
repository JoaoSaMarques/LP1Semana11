using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            GameController gameController = new GameController();
            gameController.StartGame();
        }
    }
}