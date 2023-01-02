using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedTypes
{
    internal class Program
    {
        enum CarColor : byte 
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }
        static void Main(string[] args)
        {
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
        }

        static void PaintCar(CarColor color)
        {
            Console.WriteLine("The car was painted {0} with the code {1}", color, (int)color);
        }
    }
}
