using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Employees
{
    internal class Teacher : BaseEmployee, IEmploymentInfo
    {
        public Teacher(BaseEmployee baseEmployee) : base(baseEmployee.Name, baseEmployee.Surname, baseEmployee.Age)
        {

        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}" +
                     "\n" +
                    $"\n{PositionInfo()}" +
                     "\n" +
                    $"\n{Salary()}";
        }
        public string PositionInfo()
        {
            return "---------------------------------------------------------------------------------------------------" +
                   "\n---------------------------------------------TEACHER-----------------------------------------------" +
                   "\n---------------------------------------------------------------------------------------------------" +
                   "\n" +
                   "\nIn elementary and primary schools, teachers generally teach one class of students each day about all subjects." +
                   "\nIn middle school and above, teachers typically specialize in one subject and teach students in-depth lessons." +
                   "\nThey plan curricula, assign homework, grade tests and instruct classes.";
        }

        public string Salary()
        {
            return $"Salary is: 32,343$ per year";
        }
        public static Teacher GetInfo(BaseEmployee baseEmployee)
        {
            return new Teacher(baseEmployee);
        }
    }
}
