using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("1 in Queue : {0}", queue.Contains(1));
            Console.WriteLine("Remove : {0}", queue.Dequeue());
            Console.WriteLine("Peek 1 : {0}", queue.Peek());

            int[] numArray = queue.ToArray();

            Console.WriteLine(String.Join(",", numArray));
            foreach (int i in queue)
            {
                Console.WriteLine($"Queue : {i}");
            }
            queue.Clear();
        }
    }
}