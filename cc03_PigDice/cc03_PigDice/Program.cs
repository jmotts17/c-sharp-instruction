using System;

namespace cc03_PigDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output welcome message
            Console.WriteLine("Pig Dice Game");

            // Variable declaration
            String response;
            int score;
            int rollCounter = 0;
            int totalRolls = 0;
            int highestRoll;
            int highScore;
            int highestScore = 0;
            int numOfGames;
            int totalNumOfGames = 0;

            do
            {
                // Prompt user for number of plays
                int numOfPlays = MyConsole.GetInt("\n# of times to play?: ");
                
                // Sets numOfGames, highScore and highestRoll, totalRolls to 0
                numOfGames = 0;
                highScore = 0;
                highestRoll = 0;
                totalRolls = 0;

                // Output game starting message
                Console.WriteLine("\nHere we go...");

                for (int i = 0; i < numOfPlays; i++)
                {
                    // Set dieRoll and score to 0
                    int dieRoll = 0;
                    score = 0;
                    rollCounter = 0;

                    // Increments num of games
                    numOfGames++;
                    
                    while (dieRoll != 1)
                    {
                        // Calls the RollDie method
                        dieRoll = RollDie();
                        // Counter for score total per game
                        score += dieRoll;

                        // Determines the highest roll for a set of games
                        if (dieRoll > highestRoll)
                            highestRoll = dieRoll;

                        rollCounter++;
                    }

                    // Determines the high score for a set of games
                    if (score > highScore)
                        highScore = score;

                    // Determines the highest score for all games
                    if(score > highestScore)
                        highestScore = score;

                    // Increment rolls counter
                    totalRolls += rollCounter;
                }

                // Increments number of games counter
                totalNumOfGames += numOfGames;

                // Outputs set of games results
                OutputGameResults(numOfGames, totalRolls, highestRoll, highScore);

                // Prompts user to continue
                response = MyConsole.GetString("\nContinue? (y/n): ");
            } while (response.Equals("y"));

            // Outputs total number of game results
            OutputTotalResults(totalNumOfGames, highestScore);
        }

        // Returns a dice roll
        public static int RollDie()
        {
            Random rand = new Random();
            return rand.Next(6) + 1;
        }

        // Output the total of a single set of Pig Dice Games
        public static void OutputGameResults(int numOfGames, int totalRolls, int highestRoll, int highScore)
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Pig Dice Game Results");
            Console.WriteLine($"Number of Games: {numOfGames}");
            Console.WriteLine($"Total Rolls:     {totalRolls}");
            Console.WriteLine($"Highest Roll:    {highestRoll}");
            Console.WriteLine($"Highest Score:   {highScore}");
            Console.WriteLine("=========================");
        }

        // Output the total results of all the Pig Dice Games
        public static void OutputTotalResults(int totalNumOfGames, int highestScore)
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Pig Dice Total Results");
            Console.WriteLine($"Number of Games: {totalNumOfGames}");
            Console.WriteLine($"Highest Score:   {highestScore}");
            Console.WriteLine("=========================");
        }

    }
}
