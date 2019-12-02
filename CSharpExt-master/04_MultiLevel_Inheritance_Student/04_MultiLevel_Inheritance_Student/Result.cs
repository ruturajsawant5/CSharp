using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MultiLevel_Inheritance_Student
{
    class Result:Test
    {
        public int total;
        public double percentage;

        public Result(int r, string n, int s1, int s2, int s3, int s4, int s5)
            :base( r,  n,  s1,  s2,  s3,  s4,  s5)
        {
        }

        public void calculate()
        {
            total = base.m1 + base.m2 + base.m3 + base.m4 + base.m4;
            percentage = total / 5.0;
        }

        public void display()
        {
            base.display();
            Console.WriteLine("Total Marks : " + total);
            Console.WriteLine("Percentage : " + percentage);
        }
    }
}
