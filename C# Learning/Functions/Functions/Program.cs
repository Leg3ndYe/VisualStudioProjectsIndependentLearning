using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;           DoubleIt
            //int solution;
            //DoubleIt(x, out solution);
            //Console.WriteLine("15 * 2 = {0}", solution);


            //double x = 4;        GetSum
            //double y = 5;
            //Console.WriteLine(GetSum(x, y));


            //int num3 = 10;       Swap
            //int num4 = 20;
            //Console.WriteLine("Before Swap num1 : {0} num2 : {1}", num3 , num4);
            //Swap(ref num3, ref num4);
            //Console.WriteLine("After Swap num1 : {0} num2 : {1}", num3, num4);


            //Console.WriteLine("1 + 2 + 3 = {0}",GetSumMore(1, 2, 3));       GetSumMore


            //PrintInfo(zipCode: 15147, name: "DerekBanas");                  PrintInfo


            //Console.WriteLine("5.0 + 4.5 = {0}", GetSum2(5.0, 4.5));        GetSum2
            //Console.WriteLine("5.0 + 4.5 = {0}", GetSum2("5.0", "4.5"));

        }
        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }
        static double GetSum2(string x = "1", string y = "1")
        {
            double xblX = Convert.ToDouble(x);
            double xblY = Convert.ToDouble(x);
            return xblX + xblY;
        }
        static void PrintInfo (string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }
        public static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums) 
            {
                sum += i;   
            }
            return sum;
        }
        public static void Swap (ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }
        static double GetSum (double x, double y)
        {
            return x + y;
        }
        
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
    }
}
