using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Creating_a_new_string_of_four_copies
{
    /*Task: Write a C# program to create a new string of four copies, taking last four characters from a given string. 
      If the length of the given string is less than 4 return the original one. 
            
            Input a string : The quick brown fox jumps over the lazy dog.
            Sample Output: dog.dog.dog.dog.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = " ";
            char[] storeSentence;
            Console.WriteLine("Input a strig : ");
            inputString = Console.ReadLine();
            storeSentence = inputString.ToCharArray();
            var los = storeSentence.Length;
            if (los >= 4)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int i = los - 4; los - 1 >= i; i++)
                    {
                        Console.Write("{0}", storeSentence.GetValue(i));
                    }
                }
            }
            else
            {
                Console.WriteLine(inputString);
            }
        }
    }
}
