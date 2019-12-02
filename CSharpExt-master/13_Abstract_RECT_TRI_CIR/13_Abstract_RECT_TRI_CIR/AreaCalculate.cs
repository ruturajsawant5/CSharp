using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Abstract_RECT_TRI_CIR
{
    abstract class AreaCalculate
    {
        public double dim1, dim2;

        public AreaCalculate(double d1, double d2)
        {
            dim1 = d1;
            dim2 = d2;
        }
        public abstract void display();

        public abstract void area();
    }
}
