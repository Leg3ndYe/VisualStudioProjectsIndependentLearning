using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_30_Get_the_century_from_a_year
{
    /* Write a C# program to get the century from a year.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            Console.Write("Input a year ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CenturyOutput(year));
        }
        public static int CenturyOutput(int year)
        {
            year = (year / 100) + ((year % 100 == 0) ? 0 : 1);
            return year;
        }
    }
}
