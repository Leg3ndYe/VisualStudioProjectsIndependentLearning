using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School_Employees
{
    internal class BaseEmployee
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        public BaseEmployee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public virtual string GetInfo()
        {   
            return $"Name: {Name}" +
                   $"\nSurname: {Surname}" +
                   $"\nAge: {Age}";
        }
        public static BaseEmployee GetBaseEmployeeInfo()
        {
            Console.Write("Input your name: ");
            string name = Console.ReadLine();
            Console.Write("Input your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Input your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            return new BaseEmployee(name, surname, age);
        }
    }
}
