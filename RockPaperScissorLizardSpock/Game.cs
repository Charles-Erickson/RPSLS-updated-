using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Game
    {
       
        Player PlayerOne;
        Player PlayerTwo;
        int Rounds;
        int PlayerOneWin;
        int PlayerTwoWin;

        List<string> GameActions = new List<string>();

        public void AddToGameActions()
        {
            GameActions.Add("rock");
            GameActions.Add("paper");
            GameActions.Add("scissors");
            GameActions.Add("lizard");
            GameActions.Add("spock");
        }
        public void GamePlay()
        {
         void GameRules = Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! This is a more advanced version of the classic game Rock, Paper, Scissors. " +
       " Scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons Spock, Spock smashes scissors," +
       " scissors decapitates lizard, lizard eats paper, paper disproves Spock,Spock vaporizes rock, and as it always has" +
       ", rock crushes scissors.  First, select if there will be one player or two. Then, players will select which gesture they" +
       "plan to make. After, both gestures will be compared and a winner will be declared.| IN THE EVENT OF A TIE THE ROUND WILL BE REPEATED|" +
       "The game will be played to the best two of three rounds.  Ready? Then LET'S RUMBLE!");
            //" _____      _              _   _             ___                       _ _ _ " +
            //"|  ___|    | |            | | | |           / _ \                     | | | |" +
            //"| |__ _ __ | |_ ___ _ __  | |_| |__   ___  / /_\ \_ __ ___ _ __   __ _| | | |" +
            //"|  __| '_ \| __/ _ \ '__| | __| '_ \ / _ \ |  _  | '__/ _ \ '_ \ / _` | | | |" +
            //"| |__| | | | ||  __/ |    | |_| | | |  __/ | | | | | |  __/ | | | (_| |_|_|_|" +
            //"\____/_| |_|\__\___|_|     \__|_| |_|\___| \_| |_/_|  \___|_| |_|\__,_(_|_|_)");

        }
            public void NumberOfPlayers()
        {
            Console.WriteLine("How many Players? 1 or2?");
            int Number = int.Parse(Console.ReadLine());
            if (Number == 1)
            {
                PlayerOne = new Human();
                PlayerTwo = new AI();
            }
            else if (Number == 2)
            {
                PlayerOne = new Human();
                PlayerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2");
                Console.ReadLine();
                NumberOfPlayers();
            }
        }

    

    public void CompareGestures()
    {

        if (PlayerOne.Gesture == "Rock" && PlayerTwo.Gesture == "Scissors" || PlayerOne.Gesture == "Rock" && PlayerTwo.Gesture == "Lizard")
        {
            Console.WriteLine("Player One Win");
                PlayerOne.Score++;
        }
        else if (PlayerOne.Gesture == "Paper" && PlayerTwo.Gesture == "Rock" || PlayerOne.Gesture=="Paper" && PlayerTwo.Gesture=="Spock"){
            Console.WriteLine("Player One Win");
                PlayerOne.Score++;
            }
        else if (PlayerOne.Gesture == "Scissors" && PlayerTwo.Gesture == "Paper" || PlayerOne.Gesture=="Scissors" && PlayerTwo.Gesture=="Lizard"){
            Console.WriteLine("Player One Win");
                PlayerOne.Score++;
            }
        else if (PlayerOne.Gesture == "Lizard" && PlayerTwo.Gesture == "Spock" || PlayerOne.Gesture=="Lizard" && PlayerTwo.Gesture=="Paper"){
            Console.WriteLine("Player One Win");
                PlayerOne.Score++;
            }
        else if (PlayerOne.Gesture == "Spock" && PlayerTwo.Gesture == "Scissors" || PlayerOne.Gesture=="Spock" && PlayerTwo.Gesture=="Rock"){
            Console.WriteLine("Player One Win");
                PlayerOne.Score++;
            }

       else if (PlayerTwo.Gesture == "Rock" && PlayerOne.Gesture == "Scissors" || PlayerTwo.Gesture == "Rock" && PlayerOne.Gesture == "Lizard")
            {
                Console.WriteLine("Player Two Win");
                PlayerTwo.Score++;
            }
       else if (PlayerTwo.Gesture == "Paper" && PlayerOne.Gesture == "Rock" || PlayerTwo.Gesture == "Paper" && PlayerOne.Gesture == "Spock")
            {
                Console.WriteLine("Player Two Win");
                PlayerTwo.Score++;
            }
       else if (PlayerTwo.Gesture == "Scissors" && PlayerOne.Gesture == "Paper" || PlayerTwo.Gesture == "Scissors" && PlayerOne.Gesture == "Lizard")
            {
                Console.WriteLine("Player Two Win");
                PlayerTwo.Score++;
            }
       else if (PlayerTwo.Gesture == "Lizard" && PlayerOne.Gesture == "Spock" || PlayerTwo.Gesture == "Lizard" && PlayerOne.Gesture == "Paper")
            {
                Console.WriteLine("Player Two Win");
                PlayerTwo.Score++;
            }
       else if (PlayerTwo.Gesture == "Spock" && PlayerOne.Gesture == "Scissors" || PlayerTwo.Gesture == "Spock" && PlayerOne.Gesture == "Rock")
            {
                Console.WriteLine("Player Two Win");
                PlayerTwo.Score++;
            }
       else if (PlayerOne.Gesture == PlayerTwo.Gesture)
        {
            Console.WriteLine("DRAW");
            Console.ReadLine();
            CompareGestures();
        }
        else
        {

        }
    }
    //public int GameRounds()
    //{
    //    Rounds;
    //    for (Rounds = 0; Player.score< 3; Rounds++)
    //    {
    //        CompareGestures();
    //    }



}
    }

}
}


