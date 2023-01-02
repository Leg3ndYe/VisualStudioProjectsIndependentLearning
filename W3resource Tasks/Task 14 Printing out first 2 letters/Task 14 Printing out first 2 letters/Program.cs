using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_Printing_out_first_2_letters
{
    /* Task: Write a C# program to get a new string of two characters from a given string.
    The first and second character of the given string must be "P" and "H", so PHP will be "PH". 
    Test Data: PHP
    Sample Output: PH */

    internal class Program
    {
        static void Main(string[] args)
        {
            string setString = "PHP";
            string letters = " ";
            letters = setString.Substring(0, 2);
            Console.WriteLine(letters);
        }
    }
}
