using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15_Find_the_highest_and_lowest_int
{
    /* Task: Write a C# program to find the largest and lowest values from three integer values.
     Test Data:
        Input first integer: 15
        Input second integer: 25
        Input third integer: 30
        Sample Output
            Largest of three: 30
            Lowest of three: 15*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0, highest = 0, lowest = 0;
            Console.Write("Input first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third integer: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                highest = num1;
                if (num2 > num3)
                {
                    lowest = num3;
                }
                else
                {
                    lowest = num2;
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                highest = num2;
                if (num1 > num3)
                {
                    lowest = num3;
                }
                else
                {
                    lowest = num1;
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                highest = num3;
                if (num1 > num3)
                {
                    lowest = num3;
                }
                else
                {
                    lowest = num1;
                }
            }
            Console.WriteLine("Highest of three: {0}", highest);
            Console.WriteLine("Lowest of three {0}", lowest);
        }
    }
}
