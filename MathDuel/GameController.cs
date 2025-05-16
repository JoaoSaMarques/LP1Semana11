using System;
using System.Collections.Generic;
using System.IO;

namespace MathDuel
{
    public class GameController
    {
        private readonly IView _view;
        private readonly IEnumerator<MathProblem> _problemsEnumerator;
        private int _score = 0;
        private int _wrongAnswers = 0;
        private const int MaxWrongAnswers = 3;

        public GameController(IView view, IEnumerable<MathProblem> problems)
        {
            _view = view;
            _problemsEnumerator = problems.GetEnumerator();
        }

        public void Run()
        {
            _view.Introduction();

            while (_wrongAnswers < MaxWrongAnswers)
            {
                if (!_problemsEnumerator.MoveNext())
                {
                    // No more problems
                    break;
                }

                MathProblem problem = _problemsEnumerator.Current;
                _view.ShowQuestion(problem.GetQuestion());

                string input = _view.ReadAnswer();
                if (!int.TryParse(input, out int playerAnswer))
                {
                    _view.ShowWrong(problem.CorrectAnswer);
                    _wrongAnswers++;
                    continue;
                }

                if (playerAnswer == problem.CorrectAnswer)
                {
                    _view.ShowCorrect();
                    _score++;
                }
                else
                {
                    _view.ShowWrong(problem.CorrectAnswer);
                    _wrongAnswers++;
                }
            }

            _view.ShowFinalScore(_score);
        }

        public static IEnumerable<MathProblem> GenerateRandomProblems()
        {
            Random rand = new Random();
            while (true)
            {
                int a = rand.Next(1, 11);
                int b = rand.Next(1, 11);
                int opIndex = rand.Next(3);
                char op = opIndex switch
                {
                    0 => '+',
                    1 => '-',
                    2 => '*',
                    _ => '+'
                };
                yield return new MathProblem(op, a, b);
            }
        }

        public static IEnumerable<MathProblem> ReadProblemsFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException($"Problem file not found: {filename}");
            }

            using StreamReader reader = new StreamReader(filename);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 3)
                {
                    continue; // skip invalid lines
                }

                char op = parts[0][0];
                if (!int.TryParse(parts[1], out int operand1) || !int.TryParse(parts[2], out int operand2))
                {
                    continue; // skip invalid lines
                }

                if (op != '+' && op != '-' && op != '*')
                {
                    continue; // skip invalid operators
                }

                yield return new MathProblem(op, operand1, operand2);
            }
        }
    }
}