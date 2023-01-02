using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.lenght = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.lenght = 33;
            Console.WriteLine("Rect2.lenght : {0}", rect2.lenght);

            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };
            Console.WriteLine("# of Animals : {0}", Animal.GetNumAnimals());

            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));

            int? randNum = null;
            if (randNum == null) 
            {
                Console.WriteLine("randnum is null");
            }
            if (!randNum.HasValue) 
            {
                Console.WriteLine("randnum is null");
            }

        }
        struct Rectangle
        {
            public double lenght;
            public double width;
            
            public Rectangle(double l = 1, double w = 1)
            {
                lenght = l;
                width = w;
            }
            public double Area()
            { 
                return lenght * width; 
            }
        }
    }
}
