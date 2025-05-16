using System;

namespace PlayerManagerMVC2
{
    public class ConsoleView : IView
    {
        public void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Sort players");
            Console.WriteLine("0. Quit\n");
            Console.Write("Your choice > ");
        }

        public void GoodbyeMessage()
        {
            Console.WriteLine("Bye!");
        }

        public void UnknownOptionMessage()
        {
            Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
        }

        public void Prompt(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
