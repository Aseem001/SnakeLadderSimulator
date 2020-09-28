using System;

namespace SnakeLadderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game\n");
            int startPosition = 0;
            int currentPosition = 0;
            const int noPlay = 1;
            const int ladder = 2;
            const int snake = 3;
            int dieCount = 0;
            int jump = 0;
            Random rand = new Random();
            while (currentPosition != 100)
            {
                dieCount++;

                Console.WriteLine("Dice count: " + dieCount);
                int diceValue = rand.Next(1, 7);
                Console.WriteLine("Dice value= " + diceValue);
                int options = rand.Next(1, 4);
                switch (options)
                {
                    case noPlay:
                        jump = 0;
                        Console.WriteLine("No play: Jump= " + jump);
                        break;
                    case ladder:
                        jump = diceValue;
                        Console.WriteLine("Ladder: Jump= " + jump);
                        break;
                    case snake:
                        jump = -diceValue;
                        Console.WriteLine("Snake: Jump= " + jump);
                        break;
                }
                currentPosition += jump;
                Console.WriteLine("Position after this die roll: " + currentPosition);
                if (currentPosition < 0)
                {
                    currentPosition = startPosition;
                    Console.WriteLine("Position reset to: " + currentPosition);
                }
                if (currentPosition > 100)
                {
                    currentPosition -= jump;
                    Console.WriteLine("Position reset to: " + currentPosition);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }

    }
}
