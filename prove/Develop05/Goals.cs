using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        public string Name { get; set; }
        public int Points { get; protected set; }
        public bool IsCompleted { get; protected set; }

        public Goal(string name, int points)
        {
            Name = name;
            Points = points;
            IsCompleted = false;
        }

        public abstract void RecordProgress(ref int totalPoints);
        public abstract string Display();
    }
}
