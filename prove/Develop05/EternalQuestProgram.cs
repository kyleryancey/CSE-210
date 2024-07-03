using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class EternalQuestProgram
    {
        private List<Goal> goals = new List<Goal>();
        private int totalPoints = 0;

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void RecordEvent(string goalName)
        {
            Goal goal = goals.Find(g => g.Name == goalName);
            if (goal != null)
            {
                goal.RecordProgress(ref totalPoints);
            }
            else
            {
                Console.WriteLine($"Goal: {goalName} not found.");
            }
        }

        public void DisplayGoals()
        {
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.Display());
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Total Score: {totalPoints} points");
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(totalPoints);
                foreach (var goal in goals)
                {
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points},{goal.IsCompleted},{checklistGoal.CurrentCount},{checklistGoal.TargetCount},{checklistGoal.BonusPoints}");
                    }
                    else
                    {
                        writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points},{goal.IsCompleted}");
                    }
                }
            }
        }

        public void LoadGoals(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                totalPoints = int.Parse(reader.ReadLine());
                goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts[0] == nameof(SimpleGoal))
                    {
                        var goal = new SimpleGoal(parts[1], int.Parse(parts[2]));
                        if (bool.Parse(parts[3])) goal.RecordProgress(ref totalPoints);  // Mark as completed
                        goals.Add(goal);
                    }
                    else if (parts[0] == nameof(EternalGoal))
                    {
                        var goal = new EternalGoal(parts[1], int.Parse(parts[2]));
                        goals.Add(goal);
                    }
                    else if (parts[0] == nameof(ChecklistGoal))
                    {
                        var goal = new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[5]), int.Parse(parts[6]));
                        ((ChecklistGoal)goal).SetCurrentCount(int.Parse(parts[4]));
                        if (bool.Parse(parts[3])) goal.RecordProgress(ref totalPoints);  // Mark as completed
                        goals.Add(goal);
                    }
                }
            }
        }
    }
}
