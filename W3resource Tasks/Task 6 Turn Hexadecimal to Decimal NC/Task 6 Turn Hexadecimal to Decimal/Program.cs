using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Turn_Hexadecimal_to_Decimal
{
    /*Task: Write a C# program to convert a hexadecimal number to decimal number.
        Sample Output:
        Hexadecimal number: 4B0
        Convert to Decimal number: 1200 */
    internal class Program
    {
        static void Main(string[] args)
        {
            string hexaDecimalInput = " ";
            int decimalNum = 0, power = 0, hexNum = 0;

            Console.WriteLine("Input a Hexadecimal number: ");

            hexaDecimalInput = Console.ReadLine().ToUpper();
            char[] hexaDecimalNumbers = hexaDecimalInput.ToCharArray();
            
            for (int i = hexaDecimalNumbers.Length-1; 0 <= i; i--)
            {
                int setHexNum = 16;
                setHexNum = Convert.ToInt32(Math.Pow(setHexNum, power));
                hexNum = Convert.ToInt32(hexaDecimalNumbers.GetValue(i));
                hexNum -= 48;
                decimalNum += hexNum * setHexNum;
                power++;
            }
            Console.WriteLine(decimalNum);
            
        }
    }
}
