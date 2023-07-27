using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Triangle:Shape
    {
        double sideA;
        double sideB;
        double sideC;
        double breath;
        double height;
        double area;
        double perimeter;
        public Triangle()
        {
            sideA = 0;
            sideB = 0;
            sideC = 0;
            breath = 0;
            height = 0;
            area = 0;
            perimeter = 0;
        }
        public override void Area()
        {
            base.Area();
            Console.WriteLine("Enter breath: ");
            breath = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter heigth: ");
            height = double.Parse(Console.ReadLine());
            area = 0.2 * breath * height;
        }
        public override void Perimeter()
        {
            base.Perimeter();
            Console.WriteLine("Enter sideA: ");
            sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter sideB: ");
            sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter sideC: ");
            sideC = double.Parse(Console.ReadLine());
            perimeter = sideA + sideB + sideC;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Area= " + area);
            Console.WriteLine("Perimeter= " + perimeter);
        }
    }
}
