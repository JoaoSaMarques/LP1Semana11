namespace PlayerManagerMVC2
{
    public class MenuHandler
    {
        private readonly IView view;

        public MenuHandler(IView view)
        {
            this.view = view;
        }

        public void ShowMenu()
        {
            view.ShowMenu();
        }

        public void UnknownOption()
        {
            view.UnknownOptionMessage();
        }

        public void Goodbye()
        {
            view.GoodbyeMessage();
        }
    }
}
