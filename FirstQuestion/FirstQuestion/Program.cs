using System;

namespace FirstQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NO_PLAY = 1;
            const int LADDER = 2;
            const int SNAKE = 3;
            const int WIN_POSITION = 100;
            Console.WriteLine("Welcome to Snake and Ladder Simulation(Single Player)");
            int player = 0;
            int[] playerPosition = { 0, 0 };
            Random random = new Random();
            int dieRoll;
            int[] dieRollCount = { 0, 0 };
            while (playerPosition[player] < 100)
            {
                dieRoll = random.Next(1, 7);
                dieRollCount[player]++;
                int check = random.Next(1, 4);
                switch (check)
                {
                    case NO_PLAY:
                        playerPosition[player] += 0;
                        break;
                    case LADDER:
                        if ((playerPosition[player] + dieRoll) <= 100)
                            playerPosition[player] += dieRoll;
                        break;
                    case SNAKE:
                        playerPosition[player] -= dieRoll;
                        if (playerPosition[player] < 0)
                            playerPosition[player] = 0;
                        break;
                }
                Console.WriteLine("Position of Player " + (player + 1) + " is at " + playerPosition[player]);
                if ((check == 1 || check == 3) && playerPosition[player] != WIN_POSITION)
                    if (player == 0)
                        player = 1;
                    else
                        player = 0;
            }
            Console.WriteLine("Player " + (player + 1) + " Won the game and rolled the dice " + dieRollCount[player] + " no of times to reach position 100");
        }
    }
}