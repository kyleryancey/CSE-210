class Breathing : Activity
{
    private int duration;

    public override void Run()
    {
        StartMessage("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        int timeElapsed = 0;
        while (timeElapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);
            timeElapsed += 3;

            if (timeElapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            ShowSpinner(3);
            timeElapsed += 3;
        }

        FinishMessage("Breathing", duration);
    }
}
