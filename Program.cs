using System;

namespace SnakeAndLadder
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("******Snake & Ladder Simulator******");
            Console.WriteLine("Snake and Ladder game played with single player\n");
            SnakeLadderGame game = new SnakeLadderGame();
            Console.WriteLine(game.GameLogic());
            Console.Read();
        }
    }
}
//Ladder or Snake. - Use ((RANDOM)) to check for Options - In Case of No Play the player stays in the same
//position
//- In Case of Ladder the player moves ahead by the
//number of position received in the die

//- In Case of Snake the player moves behind by the UC 3 number of position received in the die