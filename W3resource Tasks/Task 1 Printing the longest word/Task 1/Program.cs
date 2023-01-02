using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /*Task: Write a C# program to find the longest word in a string.
        Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
        Sample Output:
            following */
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = sentence.Split(' ');
            string word = " ";
            int letters = 0;
            foreach (string s in words)
            {
                if (s.Length > letters)
                {
                    word = s;
                    letters = s.Length;
                }
            }
            Console.WriteLine(word);
            
        }
     
    }
}
