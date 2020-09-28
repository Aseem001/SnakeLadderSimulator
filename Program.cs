using System;

namespace SnakeLadderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game\n");
            int startPosition = 0;
            const int noPlay = 1;
            const int ladder = 2;
            const int snake = 3;
            int dieCount = 0;
            int jump = 0;
            int noOfPlayers = 2;
            int index = 0;
            Random rand = new Random();
            int[] playerPosition = new int[noOfPlayers];
            for (int i = 0; i < noOfPlayers; i++)
                playerPosition[i] = startPosition;
            while (playerPosition[index] != 100)
            {
                
                bool flag = true;
                while (flag)
                {
                    dieCount++;
                    Console.WriteLine("Dice count: " + dieCount);
                    int diceValue = rand.Next(1, 7);
                    Console.WriteLine("Dice value= " + diceValue);
                    Console.WriteLine("Player {0} on dice",index+1);
                    int options = rand.Next(1, 4);
                    switch (options)
                    {
                        case noPlay:
                            jump = 0;
                            Console.WriteLine("No play: Jump= " + jump);
                            playerPosition[index] += jump;
                            flag = false;
                            break;
                        case ladder:
                            jump = diceValue;
                            Console.WriteLine("Ladder: Jump= " + jump);
                            playerPosition[index] += jump;
                            if (playerPosition[index] == 100)
                            {
                                flag = false;
                            }
                            break;
                        case snake:
                            jump = -diceValue;
                            playerPosition[index] += jump;
                            Console.WriteLine("Snake: Jump= " + jump);
                            flag = false;
                            break;
                    }
                    
                    Console.WriteLine("Position of player "+(index+1)+" after this die roll: " + playerPosition[index]);
                    if (playerPosition[index] < 0)
                    {
                        playerPosition[index] = startPosition;
                        Console.WriteLine("Position reset to: " + playerPosition[index]);
                    }
                    if (playerPosition[index] > 100)
                    {
                        playerPosition[index] -= jump;
                        Console.WriteLine("Position reset to: " + playerPosition[index]);
                    }
                    Console.WriteLine();
                }
                if (playerPosition[index] == 100)
                    break;
                if(index==0)
                {
                    index += 1;
                }
                else if(index==1)
                {
                    index -= 1;
                }
            }
            Console.WriteLine("Winner of the game is player {0}",index+1);
            Console.ReadKey();
        }

    }
}
