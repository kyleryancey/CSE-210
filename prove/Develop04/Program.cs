class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool continueRunning = true;

        while (continueRunning)
        {
            continueRunning = menu.ChoiceAndExecute();
        }
    }
}
