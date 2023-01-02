using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_Create_a_string_of_every_2nd_char
{
    /* Task: Write a C# program to create a new string of every other character (odd position) from the first 
    position of a given string.
    Test Data:
        Input a string: w3resource
        Sample Output: wrsuc */
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = " ";
            Console.WriteLine("Input a string: ");
            inputString = Console.ReadLine();
            char[] letters = inputString.ToCharArray();
            
            for (int i= 0; i < letters.Length; i++)
            {
                Console.Write(letters[i++]);
            }
            Console.WriteLine();
        }
    }
}
