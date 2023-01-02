using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_29_Check_if_array_has_odd_num
{
    /* Task: Write a C# program to check if an array contains an odd number.
     Test Data:
        Original array: [2, 4, 7, 8, 6]
        Check if an array contains an odd number? 
        True*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            string[] whyAmIDoingThis = { "st", "nd", "rd", "th", "th" };
            bool isTrue = false;
            int order = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                order++;
                Console.Write("Input the {0}{1} integer: ",order, whyAmIDoingThis[i]);
                numArray[i] = Convert.ToInt32(Console.ReadLine());
                if (numArray[i] / 2 == 0)
                {
                    isTrue = false;
                    break;
                }
                else
                {
                    isTrue = true;
                }
            }
            Console.WriteLine(isTrue);
            Console.WriteLine("There is an odd number in the array, give yourself a high five :)");

        }
    }
}
