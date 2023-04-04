﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SnakeAndLadder
{
    internal class SnakeLadderGame
    {
        const int snake = 1;
        const int ladder = 2;
       
        static string msg;
        public string GameLogic()
        {
            int Position = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);
            int chance = random.Next(0,3);
            
                switch (chance)
                {
                    case snake:
                        Position -= dice;
                        msg = "snake";
                        break;
                    case ladder:
                        Position += dice;
                        msg = "ladder";
                        break;
                    default:
                        msg = "No Play";
                        break;
                }
          return
               (@$"
                 You got:{msg}
                 Your position:{Position}                                              
              ");

        }
    }
}
