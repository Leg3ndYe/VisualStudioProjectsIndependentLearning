using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_Check_if_w_is_in_1_to_3_spot_in_sentence
{
    internal class Program
    {
        /* Task: Write a C# program to check if a given string contains ‘w’ character between 1 and 3 spaces.
         Test Data:
            Input a string (contains at least one 'w' char) : w3resource
            Test the string contains 'w' character between 1 and 3 times:
            Sample Output
            True */
        static void Main(string[] args)
        {
            string inputSentence = " ";
            bool isTrue = false;
            Console.Write("Input a word with w insade it: ");
            inputSentence = Console.ReadLine();
            char[] letters = inputSentence.ToCharArray();
            for (int i = 0; i < 3; i++)
            {
                if (letters[i] == 'w')
                {
                    isTrue = true;
                    break;
                }
                else
                {
                    isTrue = false;
                    continue;
                }
            }
            Console.WriteLine(isTrue);
        }
    }
}
