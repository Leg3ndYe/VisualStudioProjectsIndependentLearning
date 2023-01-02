using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Name = "Ricky",
                Surname = "Moris",
            };
            Student student2 = new Student()
            {
                Name = "Lucky",
                Surname = "Black",
            };
            Student student3 = new Student()
            {
                Name = "Morty",
                Surname = "Harris",
            };
            Console.WriteLine(student1.GetInfo());
        }
    }
}
