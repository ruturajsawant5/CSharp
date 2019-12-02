using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MultiLevel_Inheritance_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "ruturaj";
            int roll = 37;
            int m1 = 11, m2 = 12, m3 = 99, m4 = 98, m5 = 33;
            Result rs = new Result(roll, name, m1, m2, m3, m4, m5);
            rs.calculate();
            rs.display();
            Console.ReadLine();
        }
    }
}
