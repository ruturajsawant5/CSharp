using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string n="Ruturaj Sawant";
            int r=37, m1=77, m2=73;
            Result rs = new Result(r,n,m1,m2);
            rs.display();
            rs.percent_cal();
            Console.ReadLine();
        }
    }
}
