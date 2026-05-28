using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    internal class BingBangBoom
    {
        public string Name { get; set; }
        public string MainRace { get; set; }
        public string SecondaryRace { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        private static Dictionary<string, (int health, int damage)> RaceStats = new()
        {
            { "human", (100, 10) },
            { "elf", (90, 20) },
            { "brute", (150, 15) },
            { "goblin", (65, 45) },
        };

        public BingBangBoom(string name = "Test", string mainRace = "human", string secondaryRace = "None")
        {
            Name = name;
            MainRace = mainRace;
            SecondaryRace = secondaryRace;

            if (RaceStats.TryGetValue(mainRace, out var stats))
            {
                Health = stats.health;
                Damage = stats.damage;
            }
            else
            {
                Health = 100;
                Damage = 10;
                Console.WriteLine($"Warning: Race '{mainRace}' not recognized. Using Human defaults.");
            }

            if (secondaryRace != "None" && RaceStats.TryGetValue(secondaryRace, out var secondaryStats))
            {
                Health = (Health + secondaryStats.health) / 2;
                Damage = (Damage + secondaryStats.damage) / 2;
            }
        }

        public void Run()
        {

            AddCreatures();
        }

        public void AddCreatures()
        {
            List<BingBangBoom> creatures = new List<BingBangBoom>
            {
                new BingBangBoom("Henry", "human", "None"),
                new BingBangBoom(Name, MainRace, SecondaryRace),


            };

            foreach (var c in creatures)
            {
                Console.WriteLine($"{c.Name} | {c.MainRace} | Health: {c.Health} | Damage: {c.Damage}");
            }
        }
    }
}
