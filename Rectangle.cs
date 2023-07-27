using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Rectangle:Shape
    {
        double width;
        double height;
        double area;
        double perimeter;
        public Rectangle()
        {
            width = 0;
            height = 0;
            area = 0;
            perimeter = 0;
        }
        public override void Area()
        {
            base.Area();
            Console.WriteLine("Enter width: ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            height = double.Parse(Console.ReadLine());
            area = width * height;
        }
        public override void Perimeter()
        {
            base.Perimeter();
            perimeter = 2 * (width * height);
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Area= "+area);
            Console.WriteLine("Perimeter= "+perimeter);
        }
    }
}
