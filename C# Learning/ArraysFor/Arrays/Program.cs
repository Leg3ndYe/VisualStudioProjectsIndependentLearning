using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {   
        // Arrays, For loops

        // ----- FUNCTIONS ------ //
        static void PrintArray(int[] intArray, string mess)
        {
            foreach(int i in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, i);
            }
        }
        // -- END OF FUNCTIONS -- //
        static void Main(string[] args)
        {
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);
            string[] customers = { "Bob", "Sally", "Sue" };
            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.234 };
            Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());
            Console.WriteLine("Array Size : {0}", randomArray.Length);
            for (int j = 0; j < randomArray.Length; j++) 
            {
                Console.WriteLine("Array : {0} : Value : {1}", j, randomArray[j]);
            }

            Console.WriteLine("---------------------------------------------------------------------");

            string[,] custNames = new string[2,2] { {"Bob", "Smith"}, {"Sally", "Smith" } };
            Console.WriteLine("MD Value : {0}", custNames.GetValue(0, 0));
            Console.WriteLine();
            for (int j = 0; j < custNames.GetLength(0); j++)
            {
                for (int i = 0; i < custNames.GetLength(1); i++)
                {
                    Console.WriteLine(custNames[j, i]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 9, 2 };
            PrintArray(randNums, "ForEach");

            Console.WriteLine("---------------------------------------------------------------------");

            Array.Sort(randNums);
            Array.Reverse(randNums);
            Console.WriteLine("1 at index : {0}", Array.IndexOf(randNums, 1));
            randNums.SetValue(0, 1);
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int StartInd = 0;
            int lenght = 2;
            Array.Copy(srcArray, StartInd, destArray, 0, lenght);
            PrintArray(destArray, "Copy");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo: {0}", m);
            }


        }
    }
}
