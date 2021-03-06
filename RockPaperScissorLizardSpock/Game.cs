﻿using System;
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

        List<string> GameActions;

        public Game()
        {
            Rounds = 0;
            GameActions = new List<string>();
            AddToGameActions();
        }

        public void AddToGameActions()
        {
            GameActions.Add("Rock");
            GameActions.Add("Paper");
            GameActions.Add("Scissors");
            GameActions.Add("Lizard");
            GameActions.Add("Spock");
        }
        public void GamePlay()
        {
           Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! This is a more advanced version of the classic game Rock, Paper," +"\n"+
               " Scissors. Scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons Spock, Spock smashes scissors," +"\n"+
          " scissors decapitates lizard, lizard eats paper, paper disproves Spock,Spock vaporizes rock, and as it always has" +"\n"+
          ", rock crushes scissors.  First, select if there will be one player or two."+"\n"+
          " Then, players will select which gesture they" +"\n"+
          "plan to make. After, both gestures will be compared and a winner will be declared." +"\n"+
          "| IN THE EVENT OF A TIE THE ROUND WILL BE REPEATED|" +"\n"+
          "The game will be played to the best two of three rounds.  Ready? Then LET'S RUMBLE!");
            Console.ReadKey();
            Console.WriteLine(@" _____      _              _   _             ___                       _ _ _ ");
            Console.WriteLine(@"|  ___|    | |            | | | |           / _ \                     | | | |");
            Console.WriteLine(@"| |__ _ __ | |_ ___ _ __  | |_| |__   ___  / /_\ \_ __ ___ _ __   __ _| | | |");
            Console.WriteLine(@"|  __| '_ \| __/ _ \ '__| | __| '_ \ / _ \ |  _  | '__/ _ \ '_ \ / _` | | | |");
            Console.WriteLine(@"| |__| | | | ||  __/ |    | |_| | | |  __/ | | | | | |  __/ | | | (_| |_|_|_|");
            Console.WriteLine(@"\____/_| |_|\__\___|_|     \__|_| |_|\___| \_| |_/_|  \___|_| |_|\__,_(_|_|_)");
            Console.ReadKey();
            NumberOfPlayers();
            GameRounds();

        }
        public void NumberOfPlayers()
        {
            Console.WriteLine("How many Players? 1 or2?");
            int Number=0;

            try
            {
                Number = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Value needs to be a number");
            }



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
                Console.ReadKey();
                NumberOfPlayers();
            }
        }
      public void DisplayPlays()
        {
            Console.WriteLine("Player One played " + PlayerOne.Gesture);
            Console.WriteLine("Player Two played " + PlayerTwo.Gesture);
            Console.ReadKey();

        }


        public void CompareGestures()
        {
            PlayerOne.PlayerInput();
            PlayerTwo.PlayerInput();
            DisplayPlays();

            if (PlayerOne.Gesture == "Rock" && PlayerTwo.Gesture == "Scissors" || PlayerOne.Gesture == "Rock" && PlayerTwo.Gesture == "Lizard")
            {

                Console.WriteLine("Player One Win");
                PlayerOne.Score++;
                Console.ReadKey();
            }
            else if (PlayerOne.Gesture == "Paper" && PlayerTwo.Gesture == "Rock" || PlayerOne.Gesture == "Paper" && PlayerTwo.Gesture == "Spock")
            {
                Console.WriteLine("Player One Win");
                PlayerOne.Score++;
                Console.ReadKey();
            }
            else if (PlayerOne.Gesture == "Scissors" && PlayerTwo.Gesture == "Paper" || PlayerOne.Gesture == "Scissors" && PlayerTwo.Gesture == "Lizard")
            {
                Console.WriteLine("Player One Win");
                PlayerOne.Score++;
                Console.ReadKey();
            }
            else if (PlayerOne.Gesture == "Lizard" && PlayerTwo.Gesture == "Spock" || PlayerOne.Gesture == "Lizard" && PlayerTwo.Gesture == "Paper")
            {
                Console.WriteLine("Player One Win");
                PlayerOne.Score++;
                Console.ReadKey();
            }
            else if (PlayerOne.Gesture == "Spock" && PlayerTwo.Gesture == "Scissors" || PlayerOne.Gesture == "Spock" && PlayerTwo.Gesture == "Rock")
            {
                Console.WriteLine("Player One Win");
                PlayerOne.Score++;
                Console.ReadKey();
            }

            else if (PlayerTwo.Gesture == "Rock" && PlayerOne.Gesture == "Scissors" || PlayerTwo.Gesture == "Rock" && PlayerOne.Gesture == "Lizard")
            {
                Console.WriteLine("Player Two Win");
                PlayerTwo.Score++;
                Console.ReadKey();
            }
            else if (PlayerTwo.Gesture == "Paper" && PlayerOne.Gesture == "Rock" || PlayerTwo.Gesture == "Paper" && PlayerOne.Gesture == "Spock")
            {
                Console.WriteLine("Player Two Win");
                PlayerTwo.Score++;
                Console.ReadKey();
            }
            else if (PlayerTwo.Gesture == "Scissors" && PlayerOne.Gesture == "Paper" || PlayerTwo.Gesture == "Scissors" && PlayerOne.Gesture == "Lizard")
            {
                Console.WriteLine("Player Two Win");
                PlayerTwo.Score++;
                Console.ReadKey();
            }
            else if (PlayerTwo.Gesture == "Lizard" && PlayerOne.Gesture == "Spock" || PlayerTwo.Gesture == "Lizard" && PlayerOne.Gesture == "Paper")
            {
                Console.WriteLine("Player Two Win");
                PlayerTwo.Score++;
                Console.ReadKey();
            }
            else if (PlayerTwo.Gesture == "Spock" && PlayerOne.Gesture == "Scissors" || PlayerTwo.Gesture == "Spock" && PlayerOne.Gesture == "Rock")
            {
                Console.WriteLine("Player Two Win");
                PlayerTwo.Score++;
                Console.ReadKey();
            }
            else if (PlayerOne.Gesture == PlayerTwo.Gesture)
            {
                Console.WriteLine("DRAW");
                Console.ReadKey();
                CompareGestures();
            }
            else
            {

            }
        }
        public void GameRounds()
        {
            for (Rounds = 0; PlayerOne.Score < 2 || PlayerTwo.Score < 2; Rounds++)
            {
                CompareGestures();
                if (PlayerOne.Score == 2)
                {
                    Console.WriteLine("Player Two has lost. Please enjoy this video to lift your sprits");
                    Console.ReadLine();
                    System.Diagnostics.Process.Start("https://youtu.be/qjwhH_On56M");
                    break;
                }
                else if (PlayerTwo.Score == 2)
                {
                    Console.WriteLine("Player One has lost. Please enjoy this video to lift your sprits");
                    Console.ReadLine();
                    System.Diagnostics.Process.Start("https://youtu.be/qjwhH_On56M");
                    break;

                }
                else
                {

                }


            }
        }
    }
}



