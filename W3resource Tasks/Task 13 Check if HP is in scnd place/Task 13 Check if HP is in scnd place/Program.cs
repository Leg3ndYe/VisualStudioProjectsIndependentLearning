using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_Check_if_HP_is_in_scnd_place
{
    /* Task: Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".
     Test Data: PHP Tutorial
        Sample Output:
        P Tutorial */
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputData = " ";
            char[] letters;
            Console.Write("Input Test Data: ");
            inputData = Console.ReadLine();
            letters = inputData.ToCharArray();
            if (letters[1] == 'H' && letters[2] == 'P')
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (i == 1 || i == 2)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write("{0}", letters[i]);
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is no HP in a string");
            }
        }
    }
}
