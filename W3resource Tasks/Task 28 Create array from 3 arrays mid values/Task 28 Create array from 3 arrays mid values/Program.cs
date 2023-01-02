using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_28_Create_array_from_3_arrays_mid_values
{
    /* Task: Write a C# program to create a new array of length containing the middle elements of three arrays 
    (each length 3) of integers.
    Test Data:
        Array1: [1, 2, 5]
        Array2: [0, 3, 8]
        Array3: [-1, 0, 2]
        New array: [2, 3, 0]*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray1 = new int[3];
            int[] numArray2 = new int[3];
            int[] numArray3 = new int[3];
            int loops = 1;
            Console.WriteLine("Input 3 integers in Array {0}", loops);
            for (int i = 0; i < 3; i++)
            {
                numArray1[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            loops++;
            Console.WriteLine("Input 3 integers in Array {0}", loops);
            for (int i = 0; i < 3; i++)
            {
                numArray2[i] = Convert.ToInt32(Console.ReadLine());
            }
            loops++;
            Console.WriteLine("Input 3 integers in Array {0}", loops);
            for (int i = 0; i < 3; i++)
            {
                numArray3[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] lastArray = {numArray1[numArray1.Length-2], numArray2[numArray2.Length-2], numArray3[numArray3.Length-2]};
            for (int i = 0; i < lastArray.Length; i++)
            {
                Console.WriteLine(lastArray[i]);
            }
        }

    }
}
