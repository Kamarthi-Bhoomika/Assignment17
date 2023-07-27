using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Shape
    {
        public Shape()
        {
            Console.WriteLine("Base class");
        }
        public virtual string ShapeType(string type)
        {
            Console.WriteLine("Shape Type: "+type);
            return type;
        }
        public virtual void Area ()
        {
            Console.WriteLine();
        }
        public virtual void Perimeter()
        {
            Console.WriteLine();
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine();
        }
    }
}

