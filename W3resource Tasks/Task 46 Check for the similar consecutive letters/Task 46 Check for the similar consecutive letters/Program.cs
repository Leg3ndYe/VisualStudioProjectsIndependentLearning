using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_46_Check_for_the_similar_consecutive_letters
{
    /* Task:  Write a C# Sharp program to check if a given string contains two similar consecutive letters.
     Sample Output:
        Original string: PHP
            Test for consecutive similar letters! False
        Original string: PHHP
            Test for consecutive similar letters! True
        Original string: PHPP
        T   est for consecutive similar letters! True
        Original string: PPHP
            Test for consecutive similar letters! True*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "PHP";
            string str2 = "PHHP";
            string str3 = "PHPP";
            string str4 = "PPHP";
            Console.WriteLine("Original string: {0} ", str1);
            Console.WriteLine("Check for consecutivie similar letters! {0} ",CheckForConsecutive(str1));
            Console.WriteLine("Original string: {0} ", str2);
            Console.WriteLine("Check for consecutivie similar letters! {0} ", CheckForConsecutive(str2));
            Console.WriteLine("Original string: {0} ", str3);
            Console.WriteLine("Check for consecutivie similar letters! {0} ", CheckForConsecutive(str3));
            Console.WriteLine("Original string: {0} ", str4);
            Console.WriteLine("Check for consecutivie similar letters! {0} ", CheckForConsecutive(str4));
        }

        public static bool CheckForConsecutive (string str)
        {
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] == str[i+1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
