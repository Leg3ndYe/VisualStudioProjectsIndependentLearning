using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_26_Rotate_an_array
{
    /* Task: Write a C# program to rotate an array (length 3) of integers in left direction.
     Test Data:
        Array1: [1, 2, 8]
        After rotating array becomes: [2, 8, 1]*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 8 };
            LeftRotation(numArray, numArray.Length, 1);
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write("{0}",numArray[i]);
            }
            Console.WriteLine();
        }
        private static void LeftRotation(int[] numArray, int l, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = numArray[0];
                for (int j = 1; j < l; j++)
                {
                    numArray[j-1] = numArray[j];
                }
                numArray[l-1] = temp;
            }
        }
    }
}
