using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Player
    {

        protected abstract PlayerInput();
        //members variables





        //constructor






        //member methods

        public class Human : Player
        {
            protected string PlayerInput()
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

            public class AI : Player
            {


                protected string PlayerInput()
                {
                    string Gesture;
                    Random AiNumber = new Random();
                    int Play=int.Parse(AiNumber.Next(1,5));
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
                    else { }
                    

                }
            }
        }
    }
}