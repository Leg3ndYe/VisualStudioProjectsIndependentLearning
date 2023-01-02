using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_53_find_sum_of_squares_in_array
{
    /* Task: Write a C# Sharp program to find sum of squares of elements of a given array of integers.
     Sample Output:
        Sum of squares of elements of the said array: 14
        Sum of squares of elements of the said array: 29*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { -2, 0, 3, 4 };
            Console.WriteLine("Sum of squares of elements of the said array: {0}", NumOfSquares(nums1));
            Console.WriteLine("Sum of squares of elements of the said array: {0}", NumOfSquares(nums2));
        }
        public static int NumOfSquares (int[] nums)
        {
            return nums.Sum(x => x * x);
        }
    }
}
