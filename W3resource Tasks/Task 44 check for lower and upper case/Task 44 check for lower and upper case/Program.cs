using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_44_check_for_lower_and_upper_case
{
    /* Task: Write a C# Sharp program to check if a given string contains only lowercase or uppercase characters.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "PHP";
            string str2 = "python";
            string str3 = "JavaScript";
            Console.WriteLine(CheckForCase(str1));
            Console.WriteLine(CheckForCase(str2));
            Console.WriteLine(CheckForCase(str3));
        }
        public static bool CheckForCase(string str)
        {
            return str == str.ToUpper() | str == str.ToLower(); 
        }
    }
}
