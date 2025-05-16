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