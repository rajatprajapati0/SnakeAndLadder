using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SnakeAndLadder
{
    internal class SnakeLadderGame
    {
        const int snake = 1;
        const int ladder = 2;
        const int totalSteps = 100;
        static string msg;
        static int winCount;
        public int GameLogic()
        {
            int steps = 0;
            int Position = 0;

            Random random = new Random();
            while (Position < totalSteps)
            {

                int dice = random.Next(1, 7);
                int chance = random.Next(0, 3);

                switch (chance)
                {
                    case snake:
                        Position -= dice;
                        if(Position < 0) 
                        {
                         Position = 0;
                         Console.WriteLine("count below 0 play again");

                        }
                        msg = "snake~~~~~~~~~~~~<>";
                        break;
                    case ladder:
                        Position += dice;
                        if (Position > totalSteps)
                        {
                            Position -=dice;
                            Console.WriteLine("count above 100 play again");
                        }
                        msg = "ladder#############";
                        break;
                    default:
                        msg = "No Play";
                        break;
                }
                Console.WriteLine
               (@$"
                 You got no. on dice:{dice}
                 You got:{msg}
                 Your position:{Position}                  
              ");
                winCount++;
            }
                return winCount ;

        }
    }
}
