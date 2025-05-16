using System;

namespace PlayerManagerMVC2
{
    public class PlayerInputHandler
    {
        private readonly IView view;

        public PlayerInputHandler(IView view)
        {
            this.view = view;
        }

        public Player InsertPlayer()
        {
            string name;
            int score;

            view.WriteLine("\nInsert player");
            view.WriteLine("-------------\n");
            view.Prompt("Name: ");
            name = Console.ReadLine();
            view.Prompt("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            return new Player(name, score);
        }
    }
}
