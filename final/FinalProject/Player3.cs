namespace Program
{

    public class Player3: BaseballPlayer
    {
        public Player3(string name, double battingAverage, double sluggingPercentage, double onBasePercentage)
        : base(name, battingAverage, sluggingPercentage, onBasePercentage){ }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Player: {Name}, Batting Average: {BattingAverage}, Slugging Percentage: {SluggingPercentage}, On-Base Percentage: {OnBasePercentage}");
        }
    }
}