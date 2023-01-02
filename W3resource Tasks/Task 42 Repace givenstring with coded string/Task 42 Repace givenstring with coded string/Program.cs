using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_42_Repace_givenstring_with_coded_string
{
    /* Task: Write a C# Sharp program to create a coded string from a given string, using specified formula.
     Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
        Sample Output:
        969
        J8V81CRI90*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "PHP";
            string str2 = "JAVASCRIPT";
            Console.WriteLine(Code(str1));
            Console.WriteLine(Code(str2));
        }
        public static string Code(string str)
        {
            return str.Replace('P', '9').Replace('T', '0').Replace('S', '1').Replace('H', '6').Replace('A', '8');
        }
    }
}
