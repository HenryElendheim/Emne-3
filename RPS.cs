using System;
using System.Collections.Generic;
using System.Text;

namespace Undervisning_Emne_3
{
    internal class RPS
    {
        private string[] options = { "Rock", "Paper", "Scissors" };

        

        public void Run()
        {
            Console.WriteLine($"Pick a choice. Rock (1), Paper (2) or Scissors (3) | Type 'exit' to leave");
            Game();
        }


        public void Game()
        {
            //Player
            var choice = Console.ReadLine();

            if (choice == "exit")
            {
                return;
            }

            int playerNumber = int.Parse(choice);

            if (playerNumber == 1)
            {
                Console.WriteLine($"You chose: {options[0]}");
            }
            else if (playerNumber == 2)
            {
                Console.WriteLine($"You chose: {options[1]}");
            }
            else
            {
                Console.WriteLine($"You chose: {options[2]}");
            }

            //Enemy
            Random rand = new Random();
            var RNG = rand.Next(1, 4);

            if (RNG == 1)
            {
                Console.WriteLine($"The Enemy chose: {options[0]}");
            }
            else if (RNG == 2)
            {
                Console.WriteLine($"The Enemy chose: {options[1]}");
            }
            else
            {
                Console.WriteLine($"The Enemy chose: {options[2]}");
            }

            //Results
            if (RNG == playerNumber)
            {
                Console.WriteLine("Tie!");
            }

            //Player wins
            else if (RNG == 1 && playerNumber == 2)
            {
                Console.WriteLine("Player won");
            }
            else if (RNG == 2 && playerNumber == 3)
            {
                Console.WriteLine("Player won");
            }

            //Enemy wins
            else if (RNG == 2 && playerNumber == 1)
            {
                Console.WriteLine("Enemy won");
            }
            else if (RNG == 3 && playerNumber == 2)
            {
                Console.WriteLine("Enemy won");
            }
            Run();
        }
    }
}
