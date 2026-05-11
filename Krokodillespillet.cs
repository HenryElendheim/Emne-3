using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    internal class Krokodillespillet
    {
        private int _points = 0;

        public int RNG()
        {
            Random rand = new Random();
            var RNG = rand.Next(1, 11);
            return RNG;
        }

        public void Run()
        {
            for (int i = 0; i < 5; i++ )
            {
                Game();
            }
            
            Console.WriteLine($"Du fikk totalt {_points} poeng!!");
        }

        public void Game()
        {
            int n1 = RNG();
            int n2 = RNG();

            Console.WriteLine($"{n1} _ {n2}");
            var input = Console.ReadLine();
            Console.WriteLine($"{n1} {input} {n2}");

            if (input == ">" && n1 > n2)
            {
                _points++;
                Console.WriteLine($"Riktig svar! +1 poeng | {_points} Total poeng");
            }
            else if (input == "<" && n1 < n2)
            {
                _points++;
                Console.WriteLine($"Riktig svar! +1 poeng | {_points} Total poeng");
            }
            else if (input == "=" && n1 == n2)
            {
                _points++;
                Console.WriteLine($"Riktig svar! +1 poeng | {_points} Total poeng");
            }
            else
            {
                _points--;
                Console.WriteLine($"Feil svar... -1 poeng | {_points} Total poeng");
            }


        }
    }
}
