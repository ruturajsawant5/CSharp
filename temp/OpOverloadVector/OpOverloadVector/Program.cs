using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpOverloadVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(4, 5, 6);

            System.Console.Write("v1: ");
            v1.display();

            System.Console.WriteLine();

            System.Console.Write("v2: ");
            v2.display();
            System.Console.WriteLine();

            Vector v3 = v1 + v2;
            System.Console.Write("v1+v2: ");
            v3.display();
            System.Console.WriteLine();

            Vector v4 = 5 * v1;
            System.Console.Write("5*v1: ");
            v4.display();
            System.Console.WriteLine();
            
            Vector v5 = v1 * 5;
            System.Console.Write("v1*5: ");
            v5.display();
            System.Console.WriteLine();

            int m = v1 * v2;
            System.Console.Write("v1*v2: "+m);
            System.Console.WriteLine();

            System.Console.ReadKey();


        }
    }
}
