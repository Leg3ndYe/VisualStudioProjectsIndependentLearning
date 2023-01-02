using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Printing_first_500_prime_numbers
{
    /*Task: Write a C# program to compute the sum of the first 500 prime numbers.
     Sample Output:
        Sum of the first 500 prime numbers:
            824693*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int pNumberCount = 20;
            for (double num = 1; num <= pNumberCount; num++)
            {
                if(num%Math.Sqrt(num) != 0)
                {
                    if (num%2 != 0)
                    {
                        Console.WriteLine(num);
                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
