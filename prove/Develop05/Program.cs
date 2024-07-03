using System;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        EternalQuestProgram program = new EternalQuestProgram();

        program.AddGoal(new SimpleGoal("Run a marathon", 1000));
        program.AddGoal(new EternalGoal("Read scriptures", 100));
        program.AddGoal(new ChecklistGoal("Attend the temple", 50, 10, 500));

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    // Add a new goal
                    Console.WriteLine("Select goal type: 1. Simple 2. Eternal 3. Checklist");
                    string goalType = Console.ReadLine();

                    Console.WriteLine("Enter goal name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter points:");
                    int points = int.Parse(Console.ReadLine());

                    if (goalType == "1")
                    {
                        program.AddGoal(new SimpleGoal(name, points));
                    }
                    else if (goalType == "2")
                    {
                        program.AddGoal(new EternalGoal(name, points));
                    }
                    else if (goalType == "3")
                    {
                        Console.WriteLine("Enter target count:");
                        int targetCount = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter bonus points:");
                        int bonusPoints = int.Parse(Console.ReadLine());

                        program.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                    }
                    break;
                case "2":
                    // Record an event
                    Console.WriteLine("Enter goal name:");
                    string goalName = Console.ReadLine();
                    program.RecordEvent(goalName);
                    break;
                case "3":
                    // Display goals
                    program.DisplayGoals();
                    break;
                case "4":
                    // Display score
                    program.DisplayScore();
                    break;
                case "5":
                    // Save goals
                    Console.WriteLine("Enter filename to save:");
                    string saveFilename = Console.ReadLine();
                    program.SaveGoals(saveFilename);
                    break;
                case "6":
                    // Load goals
                    Console.WriteLine("Enter filename to load:");
                    string loadFilename = Console.ReadLine();
                    program.LoadGoals(loadFilename);
                    break;
                case "7":
                    // Exit
                    exit = true;
                    break;
            }
        }
    }
}
