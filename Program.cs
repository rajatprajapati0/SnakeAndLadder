﻿using System;

namespace SnakeAndLadder
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("******Snake & Ladder Simulator******");
            Console.WriteLine("Snake and Ladder game played with single player\n");
            SnakeLadderGame game = new SnakeLadderGame();
            game.GameLogic();
            Console.Read();

        }
    }
}
