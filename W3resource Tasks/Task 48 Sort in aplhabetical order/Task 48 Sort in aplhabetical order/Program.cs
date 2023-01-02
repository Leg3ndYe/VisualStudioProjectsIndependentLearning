using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_48_Sort_in_aplhabetical_order
{
    /* Task: Write a C# Sharp program to convert the letters of a given string (same case-upper/lower) into alphabetical order.
     Sample Output:
    Original string: PHP
        Convert the letters of the said string into alphabetical order: HPP
    Original string: javascript
        Convert the letters of the said string into alphabetical order: aacijprstv
    Original string: python
        Convert the letters of the said string into alphabetical order: hnopty*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "PHP";
            string str2 = "javascript";
            string str3 = "python";
            Console.WriteLine(SortInAlphabetical(str1));
            Console.WriteLine(SortInAlphabetical(str2));
            Console.WriteLine(SortInAlphabetical(str3));
        }
        public static string SortInAlphabetical (string str)
        {
            return new string (str.OrderBy(x => x).ToArray());
        }
    }
}
