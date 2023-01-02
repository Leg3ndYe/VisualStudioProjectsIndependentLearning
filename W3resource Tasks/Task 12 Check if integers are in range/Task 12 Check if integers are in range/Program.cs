using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Check_if_integers_are_in_range
{
    /* Task: Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
     Sample Output:
            Input a first number: -5
            Input a second number: 8
            True*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            bool isTrue = false;
            Console.Write("Input the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 >= -10 && num1 <= 10 && num2 >= -10 && num2 <= 10)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            if (isTrue)
            {
                Console.WriteLine("Both integers are in the range -10 : 10");
            }
            else
            {
                Console.WriteLine("Not both integers are in the range -10 : 10");

            }
            Console.WriteLine(isTrue);
        }
    }
}
