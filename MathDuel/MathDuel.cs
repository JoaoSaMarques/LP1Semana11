using System;

namespace MathDuel
{
    public class ConsoleView : IView
    {
        public void Introduction()
        {
            Console.WriteLine("=== Math Duel ===");
            Console.WriteLine("Answer the math problems correctly!");
            Console.WriteLine("You can make up to 3 mistakes.");
            Console.WriteLine();
        }

        public void ShowQuestion(string question)
        {
            Console.Write("Question: " + question + " ");
        }

        public string ReadAnswer()
        {
            return Console.ReadLine();
        }

        public void ShowCorrect()
        {
            Console.WriteLine("Correct!\n");
        }

        public void ShowWrong(int correctAnswer)
        {
            Console.WriteLine($"Wrong! The correct answer was {correctAnswer}.\n");
        }

        public void ShowFinalScore(int score)
        {
            Console.WriteLine($"Game over! Your final score is: {score}");
        }
    }
}