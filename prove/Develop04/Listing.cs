using System.Collections.Generic;

class Listing : Activity
{
    private int duration;
    private static Random random = new Random();

    public override void Run()
    {
        StartMessage("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        ShowSpinner(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"\nYou have listed {items.Count} items.");
        FinishMessage("Listing", duration);
    }

    private string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
