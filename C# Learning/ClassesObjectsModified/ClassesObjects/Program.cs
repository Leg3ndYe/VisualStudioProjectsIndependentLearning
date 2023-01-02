using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };
            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrr"
            };
            grover.Sound = "Wooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Sally");
            grover.SetAnimalIDInfo(54321, "Lukas");
            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine("Is my animal health : {0}", getHealth.HealthyWeight(11, 46));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeee"
            };
            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woofff",
                Sound2 = "Gererr"
            };
            spot.MakeSound();
            
        }
    }
}
