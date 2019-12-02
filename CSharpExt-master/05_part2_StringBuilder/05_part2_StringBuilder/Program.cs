using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_part2_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Ruturaj Sawant");

            Console.WriteLine("String : " + sb.ToString());

            sb.Append(" Ruturaj Desai");

            Console.WriteLine("Append : "+sb.ToString());

            sb.Insert(7, "zzz");

            Console.WriteLine("Insert : " + sb.ToString());

            sb.Remove(7, 3);

            Console.WriteLine("Remove : " + sb.ToString());

            sb.Replace("u", "x");
            Console.WriteLine("Replace : " + sb.ToString());

            Console.ReadLine();
        }
    }
}
