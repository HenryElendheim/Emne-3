using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    internal class HvaGjørDenneKoden
    {
        public void Run()
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            int totalLetters = 0;

            Console.WriteLine("Write anything for it to be counted. (Type 'exit' to leave)");

            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine() ?? string.Empty;
                if (text == "exit")
                {
                    break;
                }
                foreach (var character in text.ToUpper() ?? string.Empty)
                {
                    counts[(int)character]++;
                    totalLetters++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var percent = 100 * (double)counts[i] / totalLetters;
                        string output = character + " - " + percent.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                        // percent.ToString("F2") makes it so it only shows 2 decimals.
                    }
                }
            }
        }
    }
}
