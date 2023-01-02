using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_50_Takes_positive_num_and_return_nth_odd
{
    /* Task: Write a C# Sharp program which takes a positive number and return the nth odd number.
     Sample Output:
        1st odd number: 1
        2nd odd number: 3
        4th odd number: 7
        100th odd number: 199 */
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} odd number is: {1} ", num, NthOddNum(num));
        }
        public static int NthOddNum (int num)
        {
            if (num % 2 == 0)
            {
                num *= 2;
                num -= 1;
            }
            return num;
        }
    }
}
