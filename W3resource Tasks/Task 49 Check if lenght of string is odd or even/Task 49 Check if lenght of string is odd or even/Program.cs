using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_49_Check_if_lenght_of_string_is_odd_or_even
{
    /* Task: Write a C# Sharp program to check the length of a given string is odd or even. 
    Return 'Odd length' if the string length is odd otherwise 'Even length'.
    Sample Output:
    Original string: PHP
        Convert the letters of the said string into alphabetical order: Odd length
    Original string: javascript
        Convert the letters of the said string into alphabetical order: Even length
    Original string: python
        Convert the letters of the said string into alphabetical order: Even length*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "PHP";
            string str2 = "javascript";
            string str3 = "python";
            Console.WriteLine("Original string: {0} ", str1);
            Console.WriteLine("Convert the letters of the said string into alphabetical order: {0} ", OddOrEven(str1));
            Console.WriteLine("Original string: {0} ", str2);
            Console.WriteLine("Convert the letters of the said string into alphabetical order: {0} ", OddOrEven(str2));
            Console.WriteLine("Original string: {0} ", str3);
            Console.WriteLine("Convert the letters of the said string into alphabetical order: {0} ", OddOrEven(str3));
            
        }
        public static string OddOrEven(string str)
        {
            return str.Length % 2 == 0 ? "Even lenght" : "Odd lenght";
        }
    }
}
