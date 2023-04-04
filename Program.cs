using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Snake & Ladder Simulator******");
            Console.WriteLine("Snake and Ladder game played with single player\n");

            int Position = 0;
            Random random = new Random();
            int dice=random.Next(1,7);

            Position = dice;
            Console.WriteLine($"player at Position :'{Position}' \nplayer get  no. on dice :'{dice}'");

            Console.Read();

        }
    }
}
