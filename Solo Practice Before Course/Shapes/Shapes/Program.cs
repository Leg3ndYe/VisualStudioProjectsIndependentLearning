using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = ShapeInput();
            ShapeChoice(shape);

            Console.ReadLine();

            //var shape = ShapeChoice(shape);
            //shape.Output();



            //Clean code by Uncle Bob
        }

        private static string ShapeInput()
        {
            string chosenShape = "";
            Console.WriteLine("Square, Triangle, Rectangle");
            Console.Write("Choose one of the shapes: ");
            chosenShape = Console.ReadLine();
            return chosenShape;
        }

        private static void ShapeChoice(string chosenShape)
        {
            //Factory - https://refactoring.guru/design-patterns/factory-method

            if (chosenShape.Equals("Square", StringComparison.OrdinalIgnoreCase))
            {
                double x = InputSquareSideLenght();
                Square(x);
            }
            else if (chosenShape.Equals("Triangle", StringComparison.OrdinalIgnoreCase))
            {
                double[] sides = InputTriangleSideLenghts();
                var triangle = Triangle.Create(sides[0], sides[1], sides[2]);
                Console.WriteLine(triangle.OutputData());
            }
            else if (chosenShape.Equals("Rectangle", StringComparison.OrdinalIgnoreCase))
            {
                double[] sides = RectangleSideLenght();
                double x = sides[0];
                double y = sides[1];
                Rectangle(x, y);
            }
            else
            {
                FalseShapeInput();
            }
        }

        private static double InputSquareSideLenght()
        {
            double x = 0;
            Console.Write("What is the lenght of the side? : ");
            x = double.Parse(Console.ReadLine());
            return x;
        }
        private static double[] InputTriangleSideLenghts()
        {
            double x = 0;
            double y = 0;
            double z = 0;
            double[] sides = new double[3];
            Console.Write($"What is the lenght of the side? x: ");
            x = double.Parse(Console.ReadLine());
            sides[0] = x;
            Console.Write($"What is the lenght of the side? y: ");
            y = double.Parse(Console.ReadLine());
            sides[1] = y;
            Console.Write($"What is the lenght of the side? z: ");
            z = double.Parse(Console.ReadLine());
            sides[2] = z;
            
            Triangle.CheckInput(x,y,z);
            return sides;
        }
        private static double[] RectangleSideLenght()
        {
            double x = 0;
            double y = 0;
            double[] sides = new double[2];
            Console.Write($"What is the lenght of the side? x: ");
            x = double.Parse(Console.ReadLine());
            sides[0] = x;
            Console.Write($"What is the lenght of the side? y: ");
            y = double.Parse(Console.ReadLine());
            sides[1] = y;
            return sides;
        }
        
        private static void Square (double x)
        {
            Square square = new Square(x);
            Console.WriteLine(square.OutputData());
        }

        private static void Rectangle(double x, double y)
        {
            Rectangle rectangle = new Rectangle(x, y);
            Console.WriteLine(rectangle.OutputData());
        }
        private static void FalseShapeInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have failed to enter a shape. " +
                              "Restart the program.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
