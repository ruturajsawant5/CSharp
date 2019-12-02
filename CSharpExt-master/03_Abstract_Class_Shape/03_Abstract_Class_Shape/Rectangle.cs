using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract_Class_Shape
{
    class Rectangle:Shape
    {
        public Rectangle(double d1, double d2)
            : base(d1, d2)
        { 
        }
        public override void area()
        {
            Console.WriteLine("Area of Rectangle : " + (dim1*dim2));
        }
    }
}
