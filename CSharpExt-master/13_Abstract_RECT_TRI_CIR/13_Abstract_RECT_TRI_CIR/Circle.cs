﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Abstract_RECT_TRI_CIR
{
    class Circle:AreaCalculate
    {
                public Circle(double d1, double d2)
            : base(d1, d2)
        {
        }
        public override void display() 
                {
            Console.WriteLine("Dimension 1 : " + dim1);
           // Console.WriteLine("Dimension 2 : " + dim2);
        }
        public override void area()
        {
            Console.WriteLine("Area of Circle : " + (3.14*dim1 * dim2));
        }
    }
}
