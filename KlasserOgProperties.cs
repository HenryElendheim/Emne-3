using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace test
{
    internal class KlasserOgProperties
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public KlasserOgProperties(string name, int lvl)
        {
            Name = name;
            Level = lvl;
        }

        public void Run()
        {
            Console.WriteLine($"Name: {Name} | Level: {Level}");
            Console.WriteLine("Press any key to view the full list of people!");
            Console.ReadKey();
            Console.Clear();
            AddPeople();
        }

        void AddPeople()
        {
            List<KlasserOgProperties> people = new List<KlasserOgProperties>
            {
                new KlasserOgProperties("Alice", 25),
                new KlasserOgProperties("Bob", 30),
                new KlasserOgProperties("Charlie", 28),
                new KlasserOgProperties(Name, Level),
            };
            foreach (KlasserOgProperties person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Level: {person.Level}");
            }
        }
    }
}
