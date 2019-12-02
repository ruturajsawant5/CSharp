using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract_Class_Shape
{
    class Triangle:Shape
    {
                public Triangle(double d1, double d2)
            : base(d1, d2)
        { 
        }
                public override void area()
        {
            Console.WriteLine("Area of Triangle : " + (0.5*dim1*dim2));
        }
    }
}
