using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Printing_first_500_prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfFactors = 0;
            int pNumberCount = 500;
            double allTotal = 0;
            int pNum = 0;
            int num = 0;
            do
            {
                num++;
                if (num % Math.Sqrt(num) != 0)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            numOfFactors++;
                        }
                    }
                    if (numOfFactors <= 2)
                    {
                        pNum++;
                        allTotal+=num;
                    }
                    numOfFactors = 0;
                }
            } while (pNum < pNumberCount);
            Console.WriteLine(allTotal);
            
        }
    }
}
