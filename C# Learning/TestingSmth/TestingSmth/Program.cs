using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingSmth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            for (int i = 1; i <= 1000; i++) 
            {
                Console.WriteLine($"I love you {i} <3");
                Thread.Sleep(1);
            }
            
        }
    }
}
