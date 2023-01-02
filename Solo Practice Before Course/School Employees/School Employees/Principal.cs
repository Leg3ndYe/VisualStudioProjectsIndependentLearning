using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Employees
{
    internal class Principal : BaseEmployee, IEmploymentInfo
    {
        public Principal(BaseEmployee baseEmployee) : base(baseEmployee.Name, baseEmployee.Surname, baseEmployee.Age)
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
            return   "---------------------------------------------------------------------------------------------------" +
                   "\n-------------------------------------------PRINCIPAL-----------------------------------------------" +
                   "\n---------------------------------------------------------------------------------------------------" +
                   "\n" +
                   "\nA school principal hires teachers and other staff members, creates and approves curricula and manages a school's budget." +
                   "\nThe principal collaborates with staff members to ensure that their school is functioning properly." +
                   "\nThey also enforce school policies and enact disciplinary measures when necessary.";
        }

        public string Salary()
        {
            return $"Salary is: 88,392$ per year";
        }

        public static Principal GetInfo(BaseEmployee baseEmployee)
        {
            return new Principal(baseEmployee);
        }
    }
}
