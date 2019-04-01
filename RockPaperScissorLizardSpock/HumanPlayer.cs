using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{

        public class Human : Player
        {
            public override string PlayerInput()
            {
                Console.WriteLine("Please  Enter 'Rock,' 'Paper,' 'Scissors,' 'Lizard,' or 'Spock'");
            string Name = Console.ReadLine();
            Gesture= System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Name.ToLower());
            int linesOfInput = 1 + (Gesture.Length / Console.BufferWidth);
            Console.CursorTop -= linesOfInput;
            Console.CursorLeft = 0;
            Console.WriteLine(new string(' ', Gesture.Length));
            Console.CursorTop -= linesOfInput;
            Console.CursorLeft = 0;

            switch (Gesture)
                {
                    case "Rock":
                        Gesture = "Rock";
                        return Gesture;
                    case "Paper":
                        Gesture = "Paper";
                        return Gesture;
                    case "Scissors":
                        Gesture = "Scissors";
                        return Gesture;
                    case "Lizard":
                        Gesture = "Lizard";
                        return Gesture;
                    case "Spock":
                        Gesture = "Spock";
                        return Gesture;
                    default:
                        Console.WriteLine("Please enter a real Action");
                        return PlayerInput();

                }
            }

        }
}
