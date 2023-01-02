using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_45_Remove_first_and_last_letters_of_str
{
    /* Task: Write a C# Sharp program to remove the first and last elements from a given string.
     Sample Output:
    Original string: PHP
    After removing first and last elements: H
    Original string: Python
    After removing first and last elements: ytho
    Original string: JavaScript
    After removing first and last elements: avaScrip*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "PHP";
            string str2 = "Python";
            string str3 = "JavaScript";
            Console.WriteLine(RemoveFirstAndLast(str1));
            Console.WriteLine(RemoveFirstAndLast(str2));
            Console.WriteLine(RemoveFirstAndLast(str3));

        }
        public static string RemoveFirstAndLast(string str)
        {
            return str.Remove(0, 1).Remove(str.Length-2, 1);
        }
    }
}
