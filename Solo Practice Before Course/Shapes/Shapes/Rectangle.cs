using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Rectangle(double x, double y)
        {
            X = x;
            Y = y;
        }
        private double CalculateArea()
        {
            double area = X * Y;
            return area;
        }
        private double CalculateExtent()
        {
            double extent = 2 * (X + Y);
            return extent;
        }
        public virtual string OutputData()
        {
            return "Rectangle" +
                   $"\nExtent is: {CalculateExtent():f2}" +
                   $"\nArea is: {CalculateArea():f2}";
        }
    }
}
