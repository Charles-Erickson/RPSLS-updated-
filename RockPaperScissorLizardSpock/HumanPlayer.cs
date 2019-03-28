using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class HumanPlayer
    {
        public class Human : Player
        {
            public override string PlayerInput()
            {
                Console.WriteLine("Please  Enter 'Rock,' 'Paper,' 'Scissors,' 'Lizard,' or 'Spock'");
                string Answer = Console.ReadLine();
                switch (Answer)
                {
                    case "Rock":
                        Answer = "Rock";
                        return Answer;
                    case "Paper":
                        Answer = "Paper";
                        return Answer;
                    case "Scissors":
                        Answer = "Scissors";
                        return Answer;
                    case "Lizard":
                        Answer = "Lizard";
                        return Answer;
                    case "Spock":
                        Answer = "Spock";
                        return Answer;
                    default:
                        Console.WriteLine("Please enter a real Action");
                        return PlayerInput();

                }
            }
        }
    }
}
