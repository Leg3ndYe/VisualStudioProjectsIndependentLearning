using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_Check_if_one_num_is_greater_and_one_lower
{
    internal class Program
    {
        /* Task: Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
         Sample Output:
            Input a first number(<100): 75
            Input a second number(>100): 250
            True*/
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            bool isTrue = false;
            Console.WriteLine("Input a first number (<100): ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number (>100): ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (num1 < 100 && num2 > 100)
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
