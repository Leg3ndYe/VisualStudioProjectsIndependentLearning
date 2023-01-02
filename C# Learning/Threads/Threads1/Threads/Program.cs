using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        static void Print1()
        {
            for (int i = 0; i < 1000; i++) 
            {
                Console.Write(1);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(Print1);
            t.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
        }
    }
}
