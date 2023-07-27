using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Circle:Shape
    {
        double radius;
        double area;
        double perimeter;
        double pi;
        public Circle() 
        {
            radius = 0;
            pi = 3.14;
            area = 0;
            perimeter = 0;
        }
        public override void Area()
        {
            base.Area();
            Console.WriteLine("Enter radius: ");
            radius = double.Parse(Console.ReadLine());
            area = pi * radius * radius;
        }
        public override void Perimeter()
        {
            base.Perimeter();
            Console.WriteLine();
            perimeter = 2 * pi * radius;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Area= " + area);
            Console.WriteLine("Perimeter= " + perimeter);
        }

    }
}
