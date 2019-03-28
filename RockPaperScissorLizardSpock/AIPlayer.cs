﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class AIPlayer
    {
        public class AI : Player
        {
            public override string PlayerInput()
            {
                string Gesture;
                Random AiNumber = new Random();
                int Play = AiNumber.Next(1, 5);
                string Play1 = base.PlayerInput();
                Console.WriteLine(Play);
                if (Play == 1)
                {
                    Gesture = "Rock";
                    return Gesture;
                }
                else if (Play == 2)
                {
                    Gesture = "Paper";
                    return Gesture;
                }
                else if (Play == 3)
                {
                    Gesture = "Scissors";
                    return Gesture;
                }
                else if (Play == 4)
                {
                    Gesture = "Lizard";
                    return Gesture;
                }
                else if (Play == 5)
                {
                    Gesture = "Spock";
                    return Gesture;
                }
                else
                {
                    return PlayerInput();
                }
            }
        }
    }
}