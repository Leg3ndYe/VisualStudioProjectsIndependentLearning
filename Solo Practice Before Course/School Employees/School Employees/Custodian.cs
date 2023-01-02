using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Employees
{
    internal class Custodian : BaseEmployee, IEmploymentInfo
    {
        public Custodian(BaseEmployee baseEmployee) : base(baseEmployee.Name, baseEmployee.Surname, baseEmployee.Age)
        {

        }
        public override string GetInfo()
        {
            return  $"{base.GetInfo()}" +
                     "\n" +
                    $"\n{PositionInfo()}" +
                     "\n" +
                    $"\n{Salary()}";
        }

        public string PositionInfo()
        {
            return "---------------------------------------------------------------------------------------------------" +
                   "\n-------------------------------------------CUSTODIAN-----------------------------------------------" +
                   "\n---------------------------------------------------------------------------------------------------" +
                   "\n" +
                   "\nCustodians ensure that school buildings and facilities are properly cleaned and maintained." +
                   "\nThey clean classrooms, bathrooms, floors and offices. School custodians also maintain equipment" +
                   "\nand keep classrooms, bathrooms and gyms properly stocked with necessary equipment.";
        }

        public string Salary()
        {
            return $"Salary is: 27,510$ per year";
        }
        public static Custodian GetInfo(BaseEmployee baseEmployee)
        {
            return new Custodian(baseEmployee);
        }
    }
}
