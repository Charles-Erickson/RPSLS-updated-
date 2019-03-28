using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Game
    {
        //void GameRules = Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! This is a more advanced version of the classic game Rock, Paper, Scissors. " +
        //    " Scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons Spock, Spock smashes scissors," +
        //    " scissors decapitates lizard, lizard eats paper, paper disproves Spock,Spock vaporizes rock, and as it always has" +
        //    ", rock crushes scissors.  First, select if there will be one player or two. Then, players will select which gesture they" +
        //    "plan to make. After, both gestures will be compared and a winner will be declared.| IN THE EVENT OF A TIE THE ROUND WILL BE REPEATED|" +
        //    "The game will be played to the best two of three rounds.  Ready? Then LET'S RUMBLE!"); //+
        //" _____      _              _   _             ___                       _ _ _ " +
        //"|  ___|    | |            | | | |           / _ \                     | | | |" +
        //"| |__ _ __ | |_ ___ _ __  | |_| |__   ___  / /_\ \_ __ ___ _ __   __ _| | | |" +
        //"|  __| '_ \| __/ _ \ '__| | __| '_ \ / _ \ |  _  | '__/ _ \ '_ \ / _` | | | |" +
        //"| |__| | | | ||  __/ |    | |_| | | |  __/ | | | | | |  __/ | | | (_| |_|_|_|" +
        //"\____/_| |_|\__\___|_|     \__|_| |_|\___| \_| |_/_|  \___|_| |_|\__,_(_|_|_)");
        Player PlayerOne;
        Player PlayerTwo;
        int Rounds;

        List<string> GameActions = new List<string>();

        public void AddToGameActions()
        {
            GameActions.Add("rock");
            GameActions.Add("paper");
            GameActions.Add("scissors");
            GameActions.Add("lizard");
            GameActions.Add("spock");
        }
        //public void GamePlay(PlayerOne, PlayerTwo)
        //    public int NumberOfPlayers()
        //    {
        //        Console.WriteLine("How many Players? 1 or2?");
        //        int Number = int.Parse(Console.ReadLine());
        //        if (Number == 1)
        //        {
        //            PlayerOne = Human.Player;
        //            PlayerTwo = AI.Player;
        //        }
        //        else if (Number == 2)
        //        {
        //            PlayerOne = Human.Player;
        //            PlayerTwo = Human.Player;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Please enter 1 or 2");
        //            Console.ReadLine();
        //            NumberOfPlayers();
        //        }
        //    } 

        //}

        public string CompareGestures(Player1, Player2)
        {
            if (Player1 == "Rock" && Player2 == "Scissors" || Player1 == "Rock" && Player2 == "Lizard")
            {
                Console.WriteLine("Player One Win");
            }
            else if(Player1=="Paper"&& Player2 == "Rock" || Player1"Paper" && Player2"Spock"){

            }
            else if (Player1 == "Scissors" && Player2 == "Paper" || Player1"Scissors" && Player2"Lizard"){

            }
            else if (Player1 == "Lizard" && Player2 == "Spock" || Player1"Lizard" && Player2"Paper"){

            }
            else if(Player1 == "Spock" && Player2 == "Scissors" || Player1"Spock" && Player2"Rock"){

            }
        }


    }


}


