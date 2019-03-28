using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Player
    {
    
        protected  
        //members variables





        //constructor






        //member methods

        public class Human : Player
        {

            protected string PlayerInput()
            {
                Console.WriteLine("Please  Enter 'Rock,' 'Paper,' 'Scissors,' 'Lizard,' or 'Spock'");
                string Anwser = Console.ReadLine();
                switch (Anwser)
                {
                    case "Rock":
                        Input = "Rock";
                        return Input;
                    case "Paper":
                        Input = "Paper";
                        return Input;
                    case "Scissors":
                        Input = "Scissors";
                        return Input;
                    case "Lizard":
                        Input = "Lizard";
                        return Input;
                    case "Spock":
                        Input = "Spock";
                        return Input;
                    default:
                        Console.WriteLine("Please enter a real Action");
                        return PlayerInput();

                }
            }

            public class AI: Player

            public int RandomNumber()
            {
                AiNumber = Random.Next();
                return AiNumber
            }
        }
    }
}