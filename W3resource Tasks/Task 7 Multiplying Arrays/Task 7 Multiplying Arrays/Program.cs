using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Task_7_Multiplying_Arrays
{
    /*Task: Write a C# program to multiply corresponding elements of two arrays of integers. 
     Sample Output:
        Array1: [1, 3, -5, 4]
        Array2: [1, 4, -5, -2]
     Multiply corresponding elements of two arrays:
                1 12 25 -8*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 3, -5, 4 };
            int[] Array2 = { 1, 4, -5, -2 };
            int result = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                result = Convert.ToInt32(Array1.GetValue(i)) * Convert.ToInt32(Array2.GetValue(i));
                Console.Write("{0} ", result);
            }
        }
    }
}
