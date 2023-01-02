using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Peek 1 : {0}", stack.Peek());
            Console.WriteLine("Pop 1 : {0}", stack.Pop());
            Console.WriteLine("Contain 1 : {0}", stack.Contains(1));

            int[] numArray2 = stack.ToArray();
            Console.WriteLine(String.Join(", ", numArray2));

            foreach(int n in numArray2) 
            {
                Console.WriteLine($"Stack : {n}");    
            }
        }
    }
}
