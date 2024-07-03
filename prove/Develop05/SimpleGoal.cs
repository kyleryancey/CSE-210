using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override void RecordProgress(ref int totalPoints)
        {
            if (!IsCompleted)
            {
                MarkAsCompleted();
                totalPoints += Points;
                Console.WriteLine($"Completed: {Name}. You earned {Points} points.");
            }
            else
            {
                Console.WriteLine($"{Name} is already completed.");
            }
        }

        public override string Display()
        {
            return IsCompleted ? $"[X] {Name} - {Points} points" : $"[ ] {Name} - {Points} points";
        }

        private void MarkAsCompleted()
        {
            IsCompleted = true;
        }
    }
}
