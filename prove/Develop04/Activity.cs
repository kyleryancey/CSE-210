using System;
using System.Threading;

class Activity
{
    public virtual void StartMessage(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName} activity...");
        Console.WriteLine(description);
        Console.Write("Enter the duration (in seconds): ");
    }

    public virtual void FinishMessage(string activityName, int duration)
    {
        Console.WriteLine("Well done!");
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed the {activityName} activity for {duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    public virtual void Run() // Ensure the base class defines the Run method as virtual
    {
        // Placeholder method
    }
}
