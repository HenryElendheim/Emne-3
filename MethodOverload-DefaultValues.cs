using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace test
{
    internal class MethodOverload_DefaultValues
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public MethodOverload_DefaultValues(string name = "Test", int age = 0)
        {
            Name = name;
            Age = age;
        }

        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen!\nHva heter du?");
            var inputName = Console.ReadLine();
            Name = inputName;

            if (Name == "Henry" || Name == "henry")
            {
                PrintResponse("hyggelig å møte deg!");
            }
            else
            {
                PrintResponse();
            }


            Console.WriteLine("Hvor gammel er du?");
            var inputAge = Convert.ToInt32(Console.ReadLine());
            Age = inputAge;

            if (Age == 20 && Name == "Henry" || Name == "henry")
            {
                Console.Write($"{Name} er ");
                PrintResponse(Name, Age);
            }
            else
            {
                PrintResponse("Aha...", Age);
            }
        }

        public void PrintResponse(string nameUpdate = "du er snill!")
        {
            Console.WriteLine(Name + " " + nameUpdate);
        }

        public void PrintResponse(string nameUpdate, int ageUpdate = 25)
        {
            Console.WriteLine(ageUpdate + "år\nSåpass ja!");
        }

    }
}
