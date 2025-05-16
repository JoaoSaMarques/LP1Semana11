namespace MathDuel
{
    public interface IView
    {
        void Introduction();
        void ShowQuestion(string question);
        string ReadAnswer();
        void ShowCorrect();
        void ShowWrong(int correctAnswer);
        void ShowFinalScore(int score);
    }
}
