namespace Shapes
{
    internal class EquilateralTriangle : Triangle
    {

        public EquilateralTriangle(double x, double y, double z) : base(x, y, z)
        {
        }

        public override string OutputData()
        {
            return "Equilateral Triangle" +
                   $"\nExtent is: {CalculateExtent():f2}" +
                   $"\nArea is: {CalculateArea(X, Y, Z):f2}";
        }
    }
}
