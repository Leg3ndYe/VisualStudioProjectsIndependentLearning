using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new[]
            {
                new Animal{Name = "German Shephard",
                Height = 25,
                Weight = 77,
                AnimalID = 1},

                 new Animal{Name = "Chiwauwa",
                Height = 7,
                Weight = 4.6,
                AnimalID = 2},

                  new Animal{Name = "Bruno",
                Height = 30,
                Weight = 220,
                AnimalID = 3},

                  new Animal{Name = "Puggie",
                Height = 12,
                Weight = 16,
                AnimalID = 1},

                  new Animal{Name = "Beaglee",
                Height = 15,
                Weight = 23,
                AnimalID = 2}
            };

            Owner[] owners = new[]
            {
                new Owner{Name = "Doug Parks", OwnerID = 1},
                new Owner{Name = "Sally Lilsmokes", OwnerID = 2},
                new Owner{Name = "Luffy D.", OwnerID = 3}
            };

            var nameHeight = from a in animals
                             orderby a.Name
                             select new
                             {
                                 a.Name,
                                 a.Height
                             };
                             
            Array arrayNameHeight = nameHeight.ToArray();

            var innerJoin =
                from animal in animals
                join owner in owners on animal.AnimalID
                equals owner.OwnerID
                select new { OwnerName = owner.Name, AnimalName = animal.Name };

            var innerJoinTest = animals.Join(owners, 
                animal => animal.AnimalID, 
                owner => owner.OwnerID, 
                (animal, owner) => new 
                { 
                    OwnerName = owner.Name, 
                    AnimalName = animal.Name
                });

            var groupJoin =
                from owner in owners
                orderby owner.OwnerID
                join animal in animals on owner.OwnerID
                equals animal.AnimalID into ownerGroup
                select new
                {
                    Owner = owner.Name,
                    Animals = from aniaml in ownerGroup
                              orderby aniaml.Name
                              select aniaml
                };

            int totalAnimals = 0;


            foreach (var i in innerJoinTest)
            {
                Console.WriteLine("{0} owns {1}", i.OwnerName, i.AnimalName);
            }
            Console.WriteLine();

            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach(var animal in ownerGroup.Animals)
                {
                    totalAnimals++;
                    Console.WriteLine("* {0}", animal.Name);
                }
            }

            //var biggieDoggies = animals.OfType<Animal>();

            //var smAnimals = from animal in biggieDoggies
            //                where (animal.Weight > 70) && (animal.Height > 25)
            //                orderby animal.Name
            //                select animal;

            //foreach (var animal in smAnimals)
            //{
            //    Console.WriteLine("{0} weighs {1}lbs and is {2}inches tall", animal.Name, animal.Weight, animal.Height);
            //}
        }
    }
}
