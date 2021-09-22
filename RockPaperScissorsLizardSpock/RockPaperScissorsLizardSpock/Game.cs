using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        public Game()
        {
            this.playerOne = SetUpPlayerOne();
            this.playerTwo = ChooseGameType();
        }

        public void RunGame()
        {
            WelcomeMessage();
            DisplayRules();
            PlayGame();
        }

        public static Player SetUpPlayerOne()
        {
            Player playerOne;
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            playerOne = new Human(name, 0, "none");
            return playerOne;

        }

        public Player ChooseGameType()
        {
            Player playerTwo;
            Console.WriteLine("Enter 1 for one player or 2 for two player:");

            int gamePlayers = Convert.ToInt32(Console.ReadLine());

            if (gamePlayers == 1)
            {
                playerTwo = new AI();
            }
            else
            {
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                playerTwo = new Human(name, 0, "none");
            }

            return playerTwo;

        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
        }

        public void DisplayRules()
        {
            Console.WriteLine("\nEach player choses one gesture from the list\n" +
                " Rock crushes Scissors\n Scissors cuts Paper\n Paper covers Rock" +
                "\n Rock crushes Lizard\n Lizard poisons Spock\n Spock smashes Scissors\n" +
                " Scissors decapitates Lizard\n Lizard eats Paper\n Paper disproves Spock\n Spock vaporizes Rock\n");

        }


        public void PlayGame()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {

                playerOne.gesture = this.playerOne.ChooseGesture();
                Console.WriteLine(playerOne.name + " chose " + playerOne.gesture);
                playerTwo.gesture = this.playerTwo.ChooseGesture();
                Console.WriteLine(playerTwo.name + " chose " + playerTwo.gesture);
                ChooseRoundWinner(playerOne.gesture, playerTwo.gesture);
            }
            if (playerOne.score == 2)
            {
                Console.WriteLine(playerOne.name + " won the game!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " won the game!");
            }

        }

        public void ChooseRoundWinner(string p1Gesture, string p2Gesture)
        {
            if (p1Gesture == "Rock")
            {
                if (p2Gesture == "Rock")
                {
                    Console.WriteLine("TIE!\n");
                }
                else if (p2Gesture == "Paper" || p2Gesture == "Spock")
                {
                    playerTwo.score += 1;
                    Console.WriteLine(playerTwo.name + " wins round.\n");
                }
                else if (p2Gesture == "Scissors" || p2Gesture == "Lizard")
                {
                    playerOne.score += 1;
                    Console.WriteLine(playerOne.name + " wins round.\n");
                }
            }
            else if (p1Gesture == "Paper")
            {
                if (p2Gesture == "Paper")
                {
                    Console.WriteLine("TIE!\n");
                }
                else if (p2Gesture == "Rock" || p2Gesture == "Spock")
                {
                    playerOne.score += 1;
                    Console.WriteLine(playerOne.name + " wins round.\n");
                }
                else if (p2Gesture == "Scissors" || p2Gesture == "Lizard")
                {
                    playerTwo.score += 1;
                    Console.WriteLine(playerTwo.name + " wins round.\n");
                }
            }
            else if (p1Gesture == "Scissors")
            {
                if (p2Gesture == "Scissors")
                {
                    Console.WriteLine("TIE!\n");
                }
                else if (p2Gesture == "Paper" || p2Gesture == "Lizard")
                {
                    playerOne.score += 1;
                    Console.WriteLine(playerOne.name + " wins round.\n");
                }
                else if (p2Gesture == "Rock" || p2Gesture == "Spock")
                {
                    playerTwo.score += 1;
                    Console.WriteLine(playerTwo.name + " wins round.\n");
                }
            }
            else if (p1Gesture == "Lizard")
            {
                if (p2Gesture == "Lizard")
                {
                    Console.WriteLine("TIE!\n");
                }
                else if (p2Gesture == "Rock" || p2Gesture == "Scissors")
                {
                    playerTwo.score += 1;
                    Console.WriteLine(playerTwo.name + " wins round.\n");
                }
                else if (p2Gesture == "Paper" || p2Gesture == "Spock")
                {
                    playerOne.score += 1;
                    Console.WriteLine(playerOne.name + " wins round.\n");
                }
            }
            else if (p1Gesture == "Spock")
            {
                if (p2Gesture == "Spock")
                {
                    Console.WriteLine("TIE!\n");
                }
                else if (p2Gesture == "Rock" || p2Gesture == "Scissors")
                {
                    playerOne.score += 1;
                    Console.WriteLine(playerOne.name + " wins round.\n");
                }
                else if (p2Gesture == "Paper" || p2Gesture == "Lizard")
                {
                    playerTwo.score += 1;
                    Console.WriteLine(playerTwo.name + " wins round.\n");
                }
            }
        }


    }
}