namespace Program
{
    // Derived class for Player3
    public class Player1 : BaseballPlayer
    {
        public Player1(string name, double battingAverage, double sluggingPercentage, double onBasePercentage)
            : base(name, battingAverage, sluggingPercentage, onBasePercentage) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Player: {Name}, Batting Average: {BattingAverage}, Slugging Percentage: {SluggingPercentage}, On-Base Percentage: {OnBasePercentage}");
        }
    }
}
