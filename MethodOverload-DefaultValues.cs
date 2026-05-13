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

        public MethodOverload_DefaultValues(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public MethodOverload_DefaultValues()
        {

        }

        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen!\nHva heter du?");
            var inputName = Console.ReadLine();
            Name = inputName;
            
            PrintResponse($"hyggelig å møte deg {Name}!");
            //PrintResponse(); 
            //Denne koden fungerer ikke fordi metoden har 2 forskjellige outcomes med default values...
            //Aner ikke hvordan jeg ordner det akkurat nå.

            Console.WriteLine("Hvor gammel er du?");
            var inputAge = Convert.ToInt32(Console.ReadLine());
            Age = inputAge;
            PrintResponse(Age);
        }

        public void PrintResponse(string nameUpdate = "du er snill!")
        {
            Console.WriteLine(Name + " " + nameUpdate);
        }

        public void PrintResponse(int ageUpdate = 25)
        {
            Console.WriteLine(ageUpdate + "år.\nSåpass ja");
        }

    }
}
