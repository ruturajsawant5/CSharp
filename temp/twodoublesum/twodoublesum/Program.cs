using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twodoublesum
{
    class Program
    {
        static void Main(string[] args)
        {
            double d1, d2;
            System.Console.WriteLine("Enter two doubles:"); 

            d1 = Double.Parse(System.Console.ReadLine());
            d2 = Double.Parse(System.Console.ReadLine());

            double res = d1 + d2;
            System.Console.WriteLine("\nResult:");
            System.Console.Write(d1+" "+d2+" "+(d1+d2));


            System.Console.ReadKey();
        
        }
    }
}
