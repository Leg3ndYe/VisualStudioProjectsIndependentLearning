using System;

namespace Shapes
{
    internal class Square
    {
        public double X { get; set; }
        public Square(double x)
        {
            X = x;
        }
        private double CalculateArea()
        {
            double area = Math.Pow(X, 2);
            return area;
        }
        private double CalculateExtent()
        {
            double extent = 4 * X;
            return extent;
        }
        public virtual string OutputData()
        {
            return "Square" +
                   $"\nExtent is: {CalculateExtent():f2}" +
                   $"\nArea is: {CalculateArea():f2}";
        }
    }
}
