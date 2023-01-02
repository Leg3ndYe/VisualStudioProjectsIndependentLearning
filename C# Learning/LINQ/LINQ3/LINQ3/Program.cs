using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList famAnimals = new ArrayList()
            {
                new Animal{Name = "Heidi",
                Height = .8,
                Weight = 18},

                 new Animal{Name = "Shrek",
                Height = 4,
                Weight = 130},

                  new Animal{Name = "Congo",
                Height = 3.8,
                Weight = 90}
            };

            var famAnimalEnum = famAnimals.OfType<Animal>();

            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach(var animal in smAnimals) 
            { 
                Console.WriteLine("{0} weighs {1}lbs", animal.Name, animal.Weight); 
            }
        }
    }
}
