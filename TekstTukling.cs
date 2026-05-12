using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    internal class TekstTukling
    {
        public void Run()
        {
            Console.WriteLine("Type 1 to flip whatever you write\nType 2 to alter the letters of whatever you write\n\n(Type 'exit' to leave)");
            
            var input = Console.ReadLine();

            if (input == "exit")
            {
                return;
            }

            var inputNumb = int.Parse(input);

            if (inputNumb == 1)
            {
                FlippingCode();
            }
            else if (inputNumb == 2)
            {
                AlteringCode();
            }
            else Console.WriteLine("Error!"); return;
        }

        public void FlippingCode()
        {
            Console.WriteLine("This code flips whatever you write!");
            var input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string flipped = new string(charArray);

            Console.WriteLine($"The reversed text is: {flipped}");
            ContinueText();
        }

        public void AlteringCode()
        {
            Console.WriteLine("This code alters your 'e' into an 'a'!");
            var input = Console.ReadLine();

            string altered = input.Replace('e', 'a');

            Console.WriteLine($"The altered text is: {altered}");
            ContinueText();
        }

        public void ContinueText()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Run();
        }
    }
}
