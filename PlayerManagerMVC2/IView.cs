namespace PlayerManagerMVC2
{
    public interface IView
    {
        void ShowMenu();
        void GoodbyeMessage();
        void UnknownOptionMessage();
        void Prompt(string message);
        void WriteLine(string message);
    }
}
