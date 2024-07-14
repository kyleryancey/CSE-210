using System;

namespace Program
{
    // Main program class
    public class Program
    {
        public static void Main(string[] args)
        {
            // Prompt the user to enter information for Player 1
            Console.WriteLine("Enter information for Player 1:");
            string playerName1 = GetUserInput("Name");
            double playerBattingAverage1 = GetDoubleUserInput("Batting Average");
            double playerSluggingPercentage1 = GetDoubleUserInput("Slugging Percentage");
            double playerOnBasePercentage1 = GetDoubleUserInput("On-Base Percentage");

            // Create Player1 object with user input
            Player1 player1 = new Player1(playerName1, playerBattingAverage1, playerSluggingPercentage1, playerOnBasePercentage1);

            // Prompt the user to enter information for Player 2
            Console.WriteLine("\nEnter information for Player 2:");
            string playerName2 = GetUserInput("Name");
            double playerBattingAverage2 = GetDoubleUserInput("Batting Average");
            double playerSluggingPercentage2 = GetDoubleUserInput("Slugging Percentage");
            double playerOnBasePercentage2 = GetDoubleUserInput("On-Base Percentage");

            // Create Player2 object with user input
            Player2 player2 = new Player2(playerName2, playerBattingAverage2, playerSluggingPercentage2, playerOnBasePercentage2);

            // Prompt the user to enter information for Player 3
            Console.WriteLine("\nEnter information for Player 3:");
            string playerName3 = GetUserInput("Name");
            double playerBattingAverage3 = GetDoubleUserInput("Batting Average");
            double playerSluggingPercentage3 = GetDoubleUserInput("Slugging Percentage");
            double playerOnBasePercentage3 = GetDoubleUserInput("On-Base Percentage");

            // Create Player3 object with user input
            Player3 player3 = new Player3(playerName3, playerBattingAverage3, playerSluggingPercentage3, playerOnBasePercentage3);

            // Display information for all players
            Console.WriteLine("\nPlayer 1:");
            player1.DisplayInfo();

            Console.WriteLine("\nPlayer 2:");
            player2.DisplayInfo();

            Console.WriteLine("\nPlayer 3:");
            player3.DisplayInfo();

            // Determine and display the best hitter
            BaseballPlayer bestHitter = BestHitterMetric.GetBestHitter(player1, player2, player3);
            Console.WriteLine($"\nThe best hitter is {bestHitter.Name} with a metric of {(bestHitter.BattingAverage + bestHitter.SluggingPercentage + bestHitter.OnBasePercentage) / 3}");
        }

        // Helper method to get string input from user
        private static string GetUserInput(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine();
        }

        // Helper method to get double input from user
        private static double GetDoubleUserInput(string prompt)
        {
            double result;
            while (true)
            {
                Console.Write($"{prompt}: ");
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
