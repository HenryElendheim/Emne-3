using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace test
{
    internal class Hangman
    {


        public async Task Run()
        {
            var words = new[]
            {
                "jumper",
                "charging",
                "ultimate",
                "human",
                "words",
                "wares",
                "dwarf",
                "shield",
                "butler",
                "stitch",
                "stub",
                "sabotage",
                "parlor",
                "prompt",
                "heady",
                "horn",
                "bygone",
                "rework",
                "painful",
                "composer",
                "glance",
                "acquit",
                "eagle",
                "solvent",
                "backbone",
                "smart",
                "atlas",
                "leap",
                "danger",
                "bruise",
                "seminar",
                "tinge",
                "trip",
                "narrow",
                "while",
                "jaguar",
                "seminary",
                "command",
                "cassette",
                "draw",
                "anchovy",
                "scream",
                "blush",
                "organic",
                "applause",
                "parallel",
                "trolley",
                "pathos",
                "origin",
                "hang",
                "pungent",
                "angular",
                "stubble",
                "painted",
                "forward",
                "saddle",
                "muddy",
                "orchid",
                "prudence",
                "disprove",
                "yiddish",
                "lobbying",
                "neuron",
                "tumor",
                "haitian",
                "swift",
                "mantel",
                "wardrobe",
                "consist",
                "storied",
                "extreme",
                "payback",
                "control",
                "dummy",
                "influx",
                "realtor",
                "detach",
                "flake",
                "consign",
                "adjunct",
                "stylized",
                "weep",
                "prepare",
                "pioneer",
                "tail",
                "platoon",
                "exercise",
                "dummy",
                "clap",
                "actor",
                "spark",
                "dope",
                "phrase",
                "welsh",
                "wall",
                "whine",
                "fickle",
                "wrong",
                "stamina",
                "dazed",
                "cramp",
                "filet",
                "foresee",
                "seller",
                "award",
                "mare",
                "uncover",
                "drowning",
                "ease",
                "buttery",
                "luxury",
                "bigotry",
                "muddy",
                "photon",
                "snow",
                "oppress",
                "blessed",
                "call",
                "stain",
                "amber",
                "rental",
                "nominee",
                "township",
                "adhesive",
                "lengthy",
                "swarm",
                "court",
                "baguette",
                "leper",
                "vital",
                "push",
                "digger",
                "setback",
                "accused",
                "taker",
                "genie",
                "reverse",
                "fake",
                "widowed",
                "renewed",
                "goodness",
                "featured",
                "curse",
                "shocked",
                "shove",
                "marked",
                "interact",
                "mane",
                "hawk",
                "kidnap",
                "noble",
                "proton",
                "effort",
            };

            //The validChars sets the list of characters that are valid all the way from A to Z in the english alphabet.
            var validChars = new Regex("^[a-z]$");
            var chosenWord = words[new Random().Next(0, words.Length - 1)];

            int lives = 5;
            var letters = new List<string>();

            //This tells you the word from the start (Mostly for debugging)
            //Console.WriteLine($"The word is {chosenWord}");

            //The whole loop
            while (lives > 0)
            {
                var charsLeft = 0;

                foreach (var character in chosenWord)
                {
                    var letter = character.ToString();

                    if (letters.Contains(letter))
                    {
                        Console.Write(letter);
                        charsLeft--;
                    }
                    else
                    {
                        Console.Write("_");
                    }
                    charsLeft++;
                }
                Console.WriteLine(string.Empty);

                if (charsLeft == 0)
                {
                    break;
                }


                Console.WriteLine($"There are {charsLeft} letters left in this word");
                Console.Write("Type a letter: ");
                var inputKey = Console.ReadKey().Key.ToString().ToLower();
                Console.WriteLine("\n", inputKey);


                //Invalid
                if (!validChars.IsMatch(inputKey))
                {
                    Console.WriteLine("Invalid key... Try again!");
                    continue;
                }


                //Already used
                if (letters.Contains(inputKey))
                {
                    Console.WriteLine("You have already entered that key!");
                }


                //Add letter
                letters.Add(inputKey);


                //Wrong letter
                if (!chosenWord.Contains(inputKey))
                {
                    lives--;

                    if (lives > 0)
                    {
                        Console.WriteLine($"{inputKey} is not the right key!\nYou have {lives} {(lives == 1 ? "LIFE" : "LIVES")} remaning");
                    }
                }
            }

            if (lives > 0)
            {
                Console.WriteLine($"You won with {lives} {(lives == 1 ? "Life" : "Lives")} remaining\n" +
                    $"The word was {chosenWord}");
            }
            else
            {
                Console.WriteLine($"You lost! The word was {chosenWord}");
            }
        }
    }
}
