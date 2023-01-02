using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_computing_the_sum_of_digits
{
    /*Task: Write a C# program and compute the sum of the digits of an integer. 
      Sample Output:
        Input a number(integer): 12
        Sum of the digits of the said integer: 3 */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an (integer): ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;

            }
            Console.WriteLine(sum); 
        }
    }
}
