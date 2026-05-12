using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    internal class GjettTallet
    {
        public void Run()
        {
            Random rand = new Random();
            var RNG = rand.Next(1, 101);
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Guess a number between 1 - 100! (Type 'exit' to leave)");
                var input = Console.ReadLine();

                if (input == "exit")
                {
                    return;
                }

                var inputNumb = int.Parse(input);


                if (inputNumb == RNG)
                {
                    Console.WriteLine("Correct!");
                    return;
                }
                else if (inputNumb >= RNG)
                {
                    Console.WriteLine("Tallet er lavere!");
                }
                else if (inputNumb <= RNG)
                {
                    Console.WriteLine("Tallet er høyere!");
                }
            }
        }
    }
}
