using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13213
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
       
        public Student(string name = "No Name", string surname = "No Surname")
        {
            Name = name;
            Surname = surname;
        }
        public virtual string GetInfo()
        {
            return $"Name : {Name}" +
                $"\nSurname : {Surname}";
        }
        public List<Student> GetStudents() 
        {
            GetStudents().Add(this);
            return GetStudents();
        }
    }
}
