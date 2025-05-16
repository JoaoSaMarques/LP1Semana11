using System;

namespace MathDuel
{
    public class MathProblem
    {
        public char Operator { get; }
        public int Operand1 { get; }
        public int Operand2 { get; }
        public int CorrectAnswer { get; }

        public MathProblem(char op, int operand1, int operand2)
        {
            Operator = op;
            Operand1 = operand1;
            Operand2 = operand2;
            CorrectAnswer = CalculateAnswer();
        }

        private int CalculateAnswer()
        {
            return Operator switch
            {
                '+' => Operand1 + Operand2,
                '-' => Operand1 - Operand2,
                '*' => Operand1 * Operand2,
                _ => throw new ArgumentException($"Invalid operator: {Operator}")
            };
        }

        public string GetQuestion()
        {
            return $"{Operand1} {Operator} {Operand2} = ?";
        }
    }
}
