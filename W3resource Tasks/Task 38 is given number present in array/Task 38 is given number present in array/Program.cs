using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_is_given_number_present_in_array
{
    /* Task: Write a C# program to check if a given number present in an array of numbers.
     int[] nums = { 1, 3, 5, 7, 9 };*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int[] nums = { 1, 3, 5, 7, 9 };
            Console.Write("Input an integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Contains(nums, num));
        }
        public static bool Contains(int[] nums, int n)
        {
            return nums.Contains(n);
        }
    }
}
