using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        public int TargetCount { get; private set; }
        public int CurrentCount { get; private set; }
        public int BonusPoints { get; private set; }

        public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
            : base(name, points)
        {
            TargetCount = targetCount;
            BonusPoints = bonusPoints;
            CurrentCount = 0;
        }

        public override void RecordProgress(ref int totalPoints)
        {
            if (CurrentCount < TargetCount)
            {
                CurrentCount++;
                totalPoints += Points;

                if (CurrentCount == TargetCount)
                {
                    MarkAsCompleted();
                    totalPoints += BonusPoints;
                    Console.WriteLine($"Completed: {Name}. You earned {Points} points and a bonus of {BonusPoints} points!");
                }
                else
                {
                    Console.WriteLine($"Progress recorded for: {Name}. You earned {Points} points.");
                }
            }
        }

        public override string Display()
        {
            return IsCompleted
                ? $"[X] {Name} - {Points} points each time (Completed)"
                : $"[ ] {Name} - {Points} points each time (Completed {CurrentCount}/{TargetCount} times)";
        }

        private void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        // New method to set CurrentCount
        public void SetCurrentCount(int count)
        {
            CurrentCount = count;
        }
    }
}
