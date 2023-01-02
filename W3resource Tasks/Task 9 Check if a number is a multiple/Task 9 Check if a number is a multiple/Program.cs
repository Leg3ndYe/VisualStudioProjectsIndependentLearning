using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_Check_if_a_number_is_a_multiple
{
    internal class Program
    {
        /*Task: Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
            Sample Output:
            Input first integer: 15 
            True*/
        static void Main(string[] args)
        {
            int num = 0;
            bool isDivisible = false;
            Console.WriteLine("Input first integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 == 0 || num % 7 == 0)
            {
                isDivisible = true;
            }
            else
            {
                isDivisible = false;
            }
            Console.WriteLine(isDivisible);

        }
    }
}
