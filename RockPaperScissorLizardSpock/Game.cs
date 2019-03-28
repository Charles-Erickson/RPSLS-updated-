using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Game
    {
        void GameRules = Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! This is a more advanced version of the classic game Rock, Paper, Scissors. " +
            " Scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons Spock, Spock smashes scissors," +
            " scissors decapitates lizard, lizard eats paper, paper disproves Spock,Spock vaporizes rock, and as it always has" +
            ", rock crushes scissors.  First, select if there will be one player or two. Then, players will select which gesture they" +
            "plan to make. After, both gestures will be compared and a winner will be declared.| IN THE EVENT OF A TIE THE ROUND WILL BE REPEATED|" +
            "The game will be played to the best two of three rounds.  Ready? Then LET'S RUMBLE!");
        Player PlayerOne;
        Player PlayerTwo;

        List<string> GameActions = new List<string>();

        public void AddToGameActions(GameActions)
        {
            GameActions.Add("rock");
            GameActions.Add("paper");
            GameActions.Add("scissors");
            GameActions.Add("lizard");
            GameActions.Add("spock");
        }
    }
}


//public string RPSLS(PlayerInput(), PlayerInput())
//{
    
//}