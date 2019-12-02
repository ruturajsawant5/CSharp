using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Abstract_RECT_TRI_CIR
{
    class Program
    {
        static void Main(string[] args)
        {
            double d1 = 11, d2 = 22.22;

            Console.WriteLine("Rectangle : ");
            Rectangle r = new Rectangle(d1, d2);
            r.display();
            r.area();

            Console.WriteLine("Square : ");
            Square r2 = new Square(d1, d2);
            r2.display();
            r2.area();

            Console.WriteLine("Circle : ");
            Circle r3 = new Circle(d1, d2);
            r3.display();
            r3.area();

            Console.ReadLine();
        }
    }
}
