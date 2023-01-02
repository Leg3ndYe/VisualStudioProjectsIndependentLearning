using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_40_Multiply_elements_in_array_by_lenght
{
    /* Task: Write a C# Sharp program to multiply all of elements of a given array of numbers by the array length.
       int[] nums = { 1, 3, 5, 7, 9 }  Output: 5, 15, 25, 35, 45 */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 7, 9 };
            int[] multiplyed = Test(nums);
            Array.ForEach(multiplyed, Console.WriteLine);
        }
        public static int[] Test(int[] nums)
        {
            var numLenght = nums.Length;
            return nums.Select(x => x * numLenght).ToArray();
        }
    }
}
