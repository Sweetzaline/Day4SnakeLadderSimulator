using System;

namespace SeconQuestion
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Player rolls the die to get a number between 1 to 6.Rolling your Dice.............................................. ");
            int steps = 0;

            Random random = new Random();
            int rollDice = random.Next(0, 7);

            switch (rollDice)
            {
                case 1:
                    steps = steps + 1;
                    break;

                case 2:
                    steps = steps + 2;
                    break;
                case 3:
                    steps = steps + 3;
                    break;
                case 4:
                    steps = steps + 4;
                    break;
                case 5:
                    steps = steps + 5;
                    break;
                case 6:
                    steps = steps + 6;
                    break;

                default:
                    steps = steps;
                    break;
            }
            Console.WriteLine(" Your Dice Showing " + steps);
            Console.WriteLine(" Steps to go: " + steps);


        }
    }
}