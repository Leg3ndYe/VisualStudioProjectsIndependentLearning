using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace School_Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseEmployee baseEmployee = GetPositionInfo();
            Console.Clear();
            Console.WriteLine(baseEmployee.GetInfo());
        }
        private static string GetPosition()
        {
            string choice = "";
            do
            {
                Console.WriteLine("What is your position inside the school: Custodian, Teacher, Principal" + 
                    "\nYou will be forced to enter the correct input, so just do it the first time. :)");
                choice = Console.ReadLine().ToUpper();

            } while (choice != "CUSTODIAN" && choice != "TEACHER" && choice != "PRINCIPAL");
            return choice;
        }
        private static BaseEmployee GetPositionInfo()
        {
            BaseEmployee employee = BaseEmployee.GetBaseEmployeeInfo();
            string choice = GetPosition();
            if (choice == "CUSTODIAN")   
            {
               return Custodian.GetInfo(employee);
            }
            else if (choice == "TEACHER")
            {
                return Teacher.GetInfo(employee);
            }
            else if (choice == "PRINCIPAL")
            {
                return Principal.GetInfo(employee);
            }
            return null;
        }
    }
}
