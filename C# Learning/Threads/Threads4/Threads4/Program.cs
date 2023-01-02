using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads4
{
    internal class Program
    {
        static void CountTo(int maxNum)
        {
            for(int i = 0; i <= maxNum; i++) 
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(() => CountTo(10));
            t.Start();

            new Thread(() =>
            {
                CountTo(6);
                CountTo(5);
                
            }).Start();
        }
    }
}
