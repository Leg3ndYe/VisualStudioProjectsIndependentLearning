namespace Shapes
{
    internal class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double x, double y, double z) : base(x, y, z)
        {
        }

        public override string OutputData()
        {
            return "Isosceles Triangle" +
                   $"\nExtent is: {CalculateExtent():f2}" +
                   $"\nArea is: {CalculateArea(X, Y, Z):f2}";
        }
    }
}
