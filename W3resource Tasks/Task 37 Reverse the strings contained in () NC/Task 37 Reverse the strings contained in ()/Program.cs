using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_37_Reverse_the_strings_contained_in___
{
    /* Task: Write a C# program to reverse the strings contained in each pair of matching parentheses in a given 
     string and also remove the parentheses within the given string.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero1 = "p(rq)st";
            string numero2 = "(p(rq)st)";
            string numero3 = "ab(cd(ef)gh)ij";
            ReverseOrder(numero1);
           // Console.WriteLine(Counter(numero1));
        }
        public static string ReverseOrder(string reverseString)
        {
            int counternum = Counter(reverseString);
            char[] chars = reverseString.ToCharArray();
            char[] inverted = new char[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                if(chars[i] == '(' && counternum != 0)
                {
                    inverted = reverseString.Substring(i + 1, counternum).Reverse().ToArray();
                    for (int j = 0; j < inverted.Length; j++)
                    {
                        chars[i+1] = inverted[j];
                    }
                }
            }
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i]);
            }
            return reverseString;
            
        }
        public static int Counter(string reverseString)
        {
            char[] chars = reverseString.ToCharArray();
            int parantheses = 0;
            int counter = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (parantheses > 0 && chars[i] != '(' && chars[i] != ')')
                {
                    counter++;      
                }
                if (chars[i] == '(')
                {
                    parantheses++;
                }
                else if (chars[i] == ')')
                {
                    parantheses--;
                }
            }
            return counter;
        }
    }
}
