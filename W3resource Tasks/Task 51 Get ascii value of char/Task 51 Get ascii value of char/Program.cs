using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_51_Get_ascii_value_of_char
{
    internal class Program
    {
        /* Task: Write a C# Sharp program to get the ASCII value of a given character.
         Sample Output:
        Ascii value of 1 is: 49
        Ascii value of A is: 65
        Ascii value of a is: 97
        Ascii value of # is: 35*/
        static void Main(string[] args)
        {
            char c = ' ';
            Console.Write("Enter a character from which I will get you ASCII code: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Value(c));
        }
        public static int Value(char c)
        {
            return (int)c;
        }
    }
}
