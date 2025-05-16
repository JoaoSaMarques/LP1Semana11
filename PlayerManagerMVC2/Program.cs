using System;

namespace PlayerManagerMVC2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine("Error: No input file specified.");
                Environment.Exit(1);
            }

            string filename = args[0];

            ConsoleApp consoleApp = new ConsoleApp();
            if (!consoleApp.LoadPlayersFromFile(filename))
            {
                Console.Error.WriteLine($"Error: Could not read file '{filename}'.");
                Environment.Exit(1);
            }

            consoleApp.Start();
        }
    }
}
