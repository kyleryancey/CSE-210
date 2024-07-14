namespace Program
{
    // BestHitterMetric class to calculate and compare best hitter metrics
    public class BestHitterMetric
    {
        public static BaseballPlayer GetBestHitter(BaseballPlayer player1, BaseballPlayer player2, BaseballPlayer player3)
        {
            double metric1 = CalculateMetric(player1);
            double metric2 = CalculateMetric(player2);
            double metric3 = CalculateMetric(player3);

            if (metric1 > metric2 && metric1 > metric3)
            {
                return player1;
            }
            else if (metric2 > metric1 && metric2 > metric3)
            {
                return player2;
            }
            else
            {
                return player3;
            }
        }

        private static double CalculateMetric(BaseballPlayer player)
        {
            return Math.Round(player.BattingAverage + player.SluggingPercentage + player.OnBasePercentage) / 3;
        }
    }
}
