using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_36_Sort_without_moving__5
{
    internal class Program
    {
        /* Task: Write a C# program to sort the integers in ascending order without moving the number -5.
         Output: -5 70 120 236 -5 -5 280 698*/
        static void Main(string[] args)
        {
            int[] numbers = { -5, 236, 120, 70, -5, -5, 698, 280 };
            int[] numbers2 = numbers.Where(x => x != -5).OrderBy(x => x).ToArray();
            int j = 0;
            for (int i = 0; i < numbers.Length; i++)
            { 
                if (numbers[i] == -5)
                {
                    numbers[i] = -5;
                }
                else
                {
                    numbers[i] = numbers2[j];
                    j++;
                }
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
