using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Check_if_a_string_starts_with_spec_word
{
    /* Task: Write a C# program to check if a string starts with a specified word.
     Note: Suppose the sentence starts with "Hello"
        Sample Output:
        Input a string : Hello how are you?
        True*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string predictedWord = "HELLO";
            string sentence = " ";
            string[] words;
            bool isPredicted = false;
            sentence = Console.ReadLine().ToUpper();
            words = sentence.Split(new[] {" "},StringSplitOptions.None);
            
            if (words[0] == predictedWord)
            {
                isPredicted = true;
            }
            else
            {
                isPredicted = false;
            }
            Console.WriteLine(isPredicted);
            
        }
    }
}
