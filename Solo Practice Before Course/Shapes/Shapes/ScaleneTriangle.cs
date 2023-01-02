namespace Shapes
{
    internal class ScaleneTriangle : Triangle
    {
        public ScaleneTriangle(double x, double y, double z) : base(x, y, z)
        {
        }

        public override string OutputData()
        {
            return "Scalene Triangle" +
                   $"\nExtent is: {CalculateExtent():f2}" +
                   $"\nArea is: {CalculateArea(X, Y, Z):f2}";
        }
    }
}
