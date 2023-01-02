using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16_Check_for_largest_and_closest
{
    /* Task: Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
     Test Data:
        Input first integer: 15
        Input second integer: 12
        Sample Output: 15*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, closest = 0;
            Console.Write("Input first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(num1 == num2)
            {
                Console.WriteLine("Both numbers are of the same value {0}", closest);
            }
            else if (num1 > num2 && num1 <= 20 || num1 < num2 && num1 >= 20)
            {
                closest = num1;
                Console.WriteLine("Number that is closer to 20 is {0} ",closest);
            }
            else
            {
                closest = num2;
                Console.WriteLine("Number that is closer to 20 is {0} ", closest);
            }
        }
    }
}
