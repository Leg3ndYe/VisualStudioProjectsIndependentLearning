using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_52_Check_if_given_word_is_plural_or_no
{
    /* Task: Write a C# Sharp program to check whether a given word is plural or not.
     Sample Output:
        Is 'Exercise' is plural? False
        Is 'Exercises' is plural? True
        Is 'Books' is plural? True
        Is 'Book' is plural? False */
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = " ";
            Console.WriteLine("Give us a string to check if it's plural");
            str = Console.ReadLine();
            Console.WriteLine("Is {0} plural? {1} ",str ,CheckForPlural(str));
        }
        public static bool CheckForPlural(string str)
        {
            return str.EndsWith("s");
        }
    }
}
