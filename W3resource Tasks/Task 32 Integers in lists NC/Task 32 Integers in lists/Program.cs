using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_Integers_in_lists
{
    internal class Program
    {
        /* Task: Write a C# program which will accept a array of integers and checks how many integers are needed to complete the range.
         Sample Example [1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8 are not present in the list. So output will be 4.*/
        static void Main(string[] args)
        {
            int loops = 0, number = 0, numbersMissing = 0;
            Console.WriteLine("How many integers do you want to input in array?");
            Console.WriteLine("The highest integer will determine the lenght of array and the lowest the starting point");
            loops = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[loops];
            Console.Clear();
            Console.WriteLine("Okay, Input {0} integers.", loops);
            int highest = int.MinValue, lowest = int.MaxValue;
            for (int i = 0; i < loops; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > highest)
                {
                    highest = number;
                }
                if (number < lowest)
                {
                    lowest = number;
                }
                numbers[i] = number;
            }
            numbersMissing = highest - lowest - numbers.Length+1;
            int[] missingNumbers = new int[numbersMissing];
            Console.Write("The Numbers You have entered are: "); 
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} " ,numbers[i]);
            }
            Console.WriteLine();
            if (numbersMissing == 0)
            {
                Console.WriteLine("You are not missing any numbers");
            }
            else
            {
                Console.WriteLine("You are missing {0} numbers", numbersMissing);
                for (int i = lowest+1; i < highest; i++)
                {
                    if (!numbers.Contains(i))
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }      
        }
    }
}
