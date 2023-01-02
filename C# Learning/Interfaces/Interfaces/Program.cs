using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 220);
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else Console.WriteLine("The {0} can't be driven", buick.Brand);
            
            
        }
    }
}
