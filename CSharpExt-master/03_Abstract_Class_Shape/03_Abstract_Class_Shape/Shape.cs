using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract_Class_Shape
{
    abstract class Shape
    {
        public double dim1, dim2;

        public Shape(double d1, double d2)
        {
            dim1 = d1;
            dim2 = d2;
        }
        public void disp()
        {
            Console.WriteLine("Dimension 1 : " + dim1);
            Console.WriteLine("Dimension 2 : " + dim2);
        }
        public abstract void area();
    }
}
