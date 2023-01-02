using System;

namespace Class_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = GetAnimal(ChoseAnimal());
            Console.WriteLine(animal.GetInfo());
        }
        public static char ChoseAnimal()
        {
            char animal = ' ';
            Console.WriteLine("Type which of these animals would you like to be: Rabbit(R), Fox(F) or Wolf(W)" +
                "\nOr it will choose that you are a Wolf by default.");
            animal = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Clear();
            return animal;
        }
        public static Animal GetAnimal(char animal)
        {
            switch (animal)
            {
                case 'R':
                    return Rabbit.CreateDefault();
                case 'F':
                    return Fox.CreateDefault();
                default:
                    return Wolf.CreateDefault();
            }
        }
    }
}
