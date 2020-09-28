using System;

namespace SnakeLadderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game with single player\n");
            int startPosition = 0;
            Console.WriteLine("Start Position= "+startPosition);

            //Rolling of die to get a random number
            Random rand = new Random();
            int diceValue = rand.Next(1, 7);
            Console.WriteLine("Dice value= "+diceValue);

            Console.ReadKey();
        }

    }
}
