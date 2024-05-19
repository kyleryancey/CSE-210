using System;

public class Entry
{
    public string UserEntry { get; set; }
    public string Prompt { get; set; }
    public DateTime Date { get; set; }

    public Entry(string userEntry, string prompt, DateTime date)
    {
        UserEntry = userEntry;
        Prompt = prompt;
        Date = date;
    }

    public static string GeneratePrompt()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random rand = new Random();
        return prompts[rand.Next(prompts.Length)];
    }

    public static string CreateEntry()
    {
        string prompt = GeneratePrompt();
        Console.WriteLine(prompt);
        Console.Write("");
        string userEntry = Console.ReadLine();
        return userEntry;
    }
}