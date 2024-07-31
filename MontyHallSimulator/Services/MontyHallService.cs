using MontyHallSimulator.Models;

namespace MontyHallSimulator.Services
{
    public class MontyHallService
    {
        public SimulationResult Simulate(int numSimulations, bool switchDoor)
        {
            int wins = 0;
            int losses = 0;

            Random random = new Random();

            for (int i = 0; i < numSimulations; i++)
            {
                int carPosition = random.Next(0, 3);
                int playerChoice = random.Next(0, 3);
                int shownDoor = 0;

                //Find a door to open
                for (int j = 0; j < 3; j++)
                {
                    if (j != carPosition && j != playerChoice)
                    {
                        shownDoor = j;
                        break;
                    }
                }

                if (switchDoor)
                {
                    // Switch to the remaining door
                    playerChoice = 3 - playerChoice - shownDoor;
                }

                if (playerChoice == carPosition)
                {
                    wins++;
                }

            }

            return new SimulationResult
            {
                Wins = wins,
                Losses = numSimulations - wins
            };

           
        }
    }
}
