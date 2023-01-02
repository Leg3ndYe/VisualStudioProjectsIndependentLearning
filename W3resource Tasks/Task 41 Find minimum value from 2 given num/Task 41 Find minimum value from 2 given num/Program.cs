using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_41_Find_minimum_value_from_2_given_num
{
    /* Task: Write a C# Sharp program to find the minimum value from two given two numbers, represented as string.
    test("12", "43") 
    12*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string value1 = "12";
            string value2 = "43";
            Console.WriteLine(GetMinValue(value1, value2));
            
        }
        public static string GetMinValue(string value1, string value2)
        {
            return Int32.Parse(value1) > Int32.Parse(value2) ? value2 : value1;
        }
            

    }
}
