using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_31_Check_for_palindrome
{
    internal class Program
    {
        /* Task:  Write a C# program to check if a given string is a palindrome or not.
         Sample Example:
                For 'aaa' the output should be true
                For 'abcd' the output should be false*/
        static void Main(string[] args)
        {
            string sentence = " ";
            Console.WriteLine("Input a string to check if Palindrome");
            sentence = Console.ReadLine();
            Console.WriteLine(CheckIfPolindrome(sentence));
        }
        public static bool CheckIfPolindrome(string inputString)
        {
            char[] c = inputString.ToCharArray();
            Array.Reverse(c);
            return new string(c).Equals(inputString);
        }
    }
}
