using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract_Class_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            double d1 = 11, d2 = 22.22;

            Console.WriteLine("Rectangle : ");
            Rectangle r = new Rectangle(d1, d2);
            r.disp();
            r.area();

            Console.WriteLine("\n\nTriangle : ");
            d1 = 10; d2 = 20;
            Triangle t = new Triangle(d1,d2);
            t.disp();
            t.area();

            Console.ReadLine();
        }
    }
}
