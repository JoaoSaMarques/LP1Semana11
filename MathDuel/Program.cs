using System;

class Program
{
    static void Main(string[] args)
    {
        string problemFile = null;
        if (args.Length > 0)
        {
            problemFile = args[0];
        }

        MathDuel.IView view = new MathDuel.ConsoleView();
        System.Collections.Generic.IEnumerable<MathDuel.MathProblem> problems;

        if (!string.IsNullOrEmpty(problemFile))
        {
            try
            {
                problems = MathDuel.GameController.ReadProblemsFromFile(problemFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading problem file: {ex.Message}");
                return;
            }
        }
        else
        {
            problems = MathDuel.GameController.GenerateRandomProblems();
        }

        var controller = new MathDuel.GameController(view, problems);
        controller.Run();
    }
}
