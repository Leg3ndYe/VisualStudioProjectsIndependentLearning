using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19_Check_if_given_string_starts_with_w
{
    /* Task: Write a C# program to check if a given string starts with "w" and immediately followed by two "ww".
     Test Data:
        Input a string : www
        Sample Output: True */
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = " ";
            bool isTrue = false;
            Console.Write("Input a string: ");
            inputString = Console.ReadLine();
            if (inputString.Substring(0, 1) == "w" && inputString.Substring(1,2) == "ww")
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            Console.WriteLine(isTrue);
        }
    }
}
