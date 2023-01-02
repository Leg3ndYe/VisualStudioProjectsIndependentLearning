using System;

namespace Shapes
{
    internal abstract class Triangle
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public static Triangle Create(double x, double y, double z)
        {
            if ((x != y) && (y != z))
            {
                return new ScaleneTriangle(x, y, z);
            }
            else if ((x == y) && (x != z) || (y == z) && (y != x) || (z == x) && (z != y))
            {
                return new IsoscelesTriangle(x, y, z);
            }

            return new EquilateralTriangle(x, y, z);
        }

        protected Triangle(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double CalculateArea(double X, double Y, double Z)
        {
            double halfperimeter = (X + Y + Z) / 2;
            double radius = Math.Sqrt((halfperimeter - X) * (halfperimeter - Y) * (halfperimeter - Z) / halfperimeter);
            double heightX = radius * (X + Y + Z) / X;
            double area = (heightX * X) / 2;
            return area;
        }

        protected double CalculateExtent() => X + Y + Z;

        public abstract string OutputData();

        public static void CheckInput(double x, double y, double z)
        {
            if ((x + y) <= z || (x + z) <= y || (y + z) <= x)
            {
                Console.WriteLine("Wrong input of side lenghts, " +
                    "the sum of 2 sides can not exceed the lenght of the third side");
                System.Environment.Exit(0);
            }
        }
    }
}
