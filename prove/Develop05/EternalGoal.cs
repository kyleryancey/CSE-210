using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) { }

        public override void RecordProgress(ref int totalPoints)
        {
            totalPoints += Points;
            Console.WriteLine($"Recorded progress for: {Name}. You earned {Points} points.");
        }

        public override string Display()
        {
            return $"[ ] {Name} - {Points} points each time";
        }
    }
}
