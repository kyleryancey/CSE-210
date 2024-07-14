namespace Program
{
    // Base class for baseball players
    public abstract class BaseballPlayer
    {
        public string Name { get; set; }
        public double BattingAverage { get; set; }
        public double SluggingPercentage { get; set; }
        public double OnBasePercentage { get; set; }

        public BaseballPlayer(string name, double battingAverage, double sluggingPercentage, double onBasePercentage)
        {
            Name = name;
            BattingAverage = battingAverage;
            SluggingPercentage = sluggingPercentage;
            OnBasePercentage = onBasePercentage;
        }

        public abstract void DisplayInfo();
    }
}
