using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Reverse_the_order_of_words_in_a_sentence
{
    /*Task: Write a C# program to reverse the words of a sentence.
     Sample Output:
        Original String: Display the pattern like pyramid using the alphabet.
        Reverse String: alphabet. the using pyramid like pattern the Display*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Original String: Display the pattern like pyramid using the alphabet.";
            string[] words = sentence.Split(' ');
            
            Console.WriteLine(sentence);
            
        }
    }
}
