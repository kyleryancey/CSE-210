using System.Collections.Generic;

class Reflecting : Activity
{
    private int duration;
    private static Random random = new Random();

    public override void Run()
    {
        StartMessage("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");

        int timeElapsed = 0;
        while (timeElapsed < duration)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"\n{question}");
            ShowSpinner(5);
            timeElapsed += 5;
        }

        FinishMessage("Reflecting", duration);
    }

    private string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    private string GetRandomQuestion()
    {
        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        int index = random.Next(questions.Count);
        return questions[index];
    }
}
