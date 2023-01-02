using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_43_Count_specified_char_in_str
{
    /* Task: Write a C# Sharp program to count a specified character (both cases) in a given string.    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "PHP Excercises";
            string str2 = "Latest News, Breaking News LIVE";
            Console.WriteLine(CharCounter(str1, 'e', 'E'));
            Console.WriteLine(CharCounter(str2, 'a', 'A'));
        }
        public static int CharCounter(string str, char c, char C)
        {
            return str.Split(c, C).Length-1;
        }    

    }
}
