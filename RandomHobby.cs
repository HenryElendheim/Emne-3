using System;
using System.Collections.Generic;
using System.Text;

namespace Undervisning_Emne_3
{
    internal class RandomHobby
    {
        private string[] _hobbies = { "Hobby 1", "Hobby 2", "Hobby 3", "Hobby 4", "Hobby 5" };

        public void Run()
        {
            Console.WriteLine("Who wants a new hobby?");
            string name = Console.ReadLine();

            Random rand = new Random();
            var RNG = rand.Next(0, 5);
            Console.WriteLine($"{name} has now got a new hobby called {_hobbies[RNG]}!");
        }
    }
}