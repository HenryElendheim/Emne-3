using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    internal class GameCharacter
    {
        public string Name;
        public int Health;
        public int Dmg;
        public int Stam;

        public bool isRunning = true;

        private List<GameCharacter> characters, enemies;

        public GameCharacter(string name = "NPC", int health = 10, int dmg = 0, int stam = 0)
        {
            Name = name;
            Health = health;
            Dmg = dmg;
            Stam = stam;
        }

        public void Run()
        {
            Console.Clear();
            initChar();
            while (isRunning == true)
            {
                Console.Clear();
                ShowCharacters();
                Console.WriteLine("\n1 - Fight | 2 - Recharge\n");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    Fight();
                    ShowCharacters();
                }
                else if (input == "2")
                {
                    Console.Clear();
                    Recharge();
                    ShowCharacters();
                }
                CheckWinner();
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("\nThank you for playing!\n");
        }

        void initChar()
        {
            characters = new List<GameCharacter>
            {
                new GameCharacter ("Hero", 100, 20, 40),
            };

            enemies = new List<GameCharacter>
            {
                new GameCharacter ("Boss", 400, 25, 10),
            };
        }

        public void ShowCharacters()
        {
            foreach (GameCharacter character in characters)
            {
                foreach (GameCharacter enemy in enemies)
                {
                    Console.WriteLine($"\n{character.Name} | Health: {character.Health} | Damage: {character.Dmg} | Stamina: {character.Stam}" +
                        $"\n{enemy.Name} | Health: {enemy.Health} | Damage: {enemy.Dmg} | Stamina: {enemy.Stam}");
                }
            }
        }

        void Fight()
        {
            foreach (GameCharacter character in characters)
            {
                foreach (GameCharacter enemy in enemies)
                {
                    Console.Clear();
                    Random rand = new Random();
                    var RNG = rand.Next(0, 30);

                    enemy.Dmg = RNG;

                    if (character.Stam <= 0)
                    {
                        Console.WriteLine($"{character.Name} is too exhausted...");
                    }
                    else
                    {
                        enemy.Health -= character.Dmg;
                        character.Stam -= 10;
                        Console.WriteLine($"{enemy.Name} took {character.Dmg} damage from {character.Name}!");
                    }


                    if (enemy.Stam <= 0)
                    {
                        Console.WriteLine($"{enemy.Name} is too tired to attack...");
                    }
                    else
                    {
                        Console.WriteLine($"{character.Name} took {enemy.Dmg} damage from {enemy.Name}!");
                        character.Health -= enemy.Dmg;
                        enemy.Stam -= 10;
                    }
                }
            }

        }

        void Recharge()
        {
            foreach (GameCharacter character in characters)
            {
                foreach (GameCharacter enemy in enemies)
                {
                    character.Stam = 40;
                    enemy.Stam = 10;
                    Console.WriteLine($"Energy recharged!");
                }
            }
        }

        void CheckWinner()
        {
            foreach (GameCharacter character in characters)
            {
                foreach (GameCharacter enemy in enemies)
                {
                    if (character.Health <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"{character.Name} has lost...\n{enemy.Name} has won...");
                        isRunning = false;
                    }
                    else if (enemy.Health <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"{character.Name} has won!\n{enemy.Name} has lost!!");
                        isRunning = false;
                    }
                }
            }
        }
    }
}
