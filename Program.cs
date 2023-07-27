using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.ShapeType("Circle");
            circle.Area();
            circle.Perimeter();
            circle.PrintInfo();

            Rectangle rectangle = new Rectangle();
            rectangle.ShapeType("Rectangle");
            rectangle.Area();
            rectangle.Perimeter();
            rectangle.PrintInfo();

            Triangle triangle = new Triangle();
            triangle.ShapeType("Triangle");
            triangle.Area();
            triangle.Perimeter();
            triangle.PrintInfo();

            Console.ReadKey();
        }
    }
}
