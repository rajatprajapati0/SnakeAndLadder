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
        static int CountOfFristPlayer;
        static int CountOfSecondPlayer;

        public void GameLogic()
        {
            int steps = 0;
            int PositionOfFirstPlayer = 0;
            int PositionOfSecondPlayer = 0;


            Random random = new Random();
            //First Palyer

            while (PositionOfFirstPlayer < totalSteps && PositionOfSecondPlayer < totalSteps)
            {
                bool turn = true;

                while (turn == true)
                {
                    int dice = random.Next(1, 7);
                    int chance = random.Next(0, 3);
                
                    switch (chance)
                    {
                        case snake:
                            PositionOfFirstPlayer -= dice;
                            if (PositionOfFirstPlayer < 0)
                            {
                                PositionOfFirstPlayer = 0;
                                Console.WriteLine("count below 0 play again");
                            }
                            msg = "snake~~~~~~~~~~~~<>";
                            turn = false;
                            break;
                        case ladder:
                            PositionOfFirstPlayer += dice;
                            if (PositionOfFirstPlayer > totalSteps)
                            {
                                PositionOfFirstPlayer -= dice;
                                Console.WriteLine("count above 100 play again");
                            }
                            if (PositionOfFirstPlayer == totalSteps)
                            {
                                turn = false;
                                Console.WriteLine(@"//////////////////////////////////////////////////////// END \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");

                            }
                            msg = "ladder#############";
                            break;
                        default:
                            msg = "No Play";
                            turn = false;
                            break;
                    }
                    CountOfFristPlayer++;
                    
                    Console.WriteLine
                   (@$"
                  ** Turn of first player **
                first player got no. on dice:{dice}
                first player got:{msg}
                first player position:{PositionOfFirstPlayer} 
                count of dice:[{CountOfFristPlayer}]
              ");
                }
            
                if (PositionOfFirstPlayer == totalSteps)
                {
                    Console.WriteLine(@$"first player is winner {PositionOfFirstPlayer}
                                     second player losser {PositionOfSecondPlayer}
                                   ");
                    break;

                }


                //Second Palyer
                while (turn == false)
                {
                    int dice = random.Next(1, 7);
                    int chance = random.Next(0, 3);
                    switch (chance)
                    {
                        case snake:
                            PositionOfSecondPlayer -= dice;
                            if (PositionOfSecondPlayer < 0)
                            {
                                PositionOfSecondPlayer = 0;
                                Console.WriteLine("count below 0 play again");
                            }
                            msg = "snake~~~~~~~~~~~~<>";
                            turn = true;
                            break;
                        case ladder:
                            PositionOfSecondPlayer += dice;
                            if (PositionOfSecondPlayer > totalSteps)
                            {
                                PositionOfSecondPlayer -= dice;
                                Console.WriteLine("count above 100 play again");
                            }
                            if (PositionOfSecondPlayer == totalSteps)
                            {
                                turn = true;
                                Console.WriteLine(@"//////////////////////////////////////////////////////// END \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");

                            }
                            msg = "ladder#############";
                            break;
                        default:
                            msg = "No Play";
                            turn = true;
                            break;
                    }
                    CountOfSecondPlayer++;
                   Console.WriteLine
                   (@$"
                                                     ** turn of second player **
                                                      second player got no. on dice:{dice}
                                                      second player got:{msg}
                                                      second player position:{PositionOfSecondPlayer}  
                                                      count of dice:[{CountOfSecondPlayer}]

                  ");



                }
                if (PositionOfSecondPlayer == totalSteps)
                {

                    Console.WriteLine(@$"                    second player is winner {PositionOfSecondPlayer}
                                                             first player losser {PositionOfFirstPlayer}
                                   ");
                    break;
                }


            }

        }
    }
}