using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MultiLevel_Inheritance_Student
{
    class Test:Student
    {
        public int m1, m2, m3, m4, m5;
        public Test(int r, string n, int s1, int s2, int s3, int s4, int s5)
            : base(r, n)
        {
            m1 = s1;
            m2 = s2;
            m3 = s3;
            m4 = s4;
            m5 = s5;
        }
        public void display()
        {
            base.display();
            Console.WriteLine("Subject 1 : " + m1);
            Console.WriteLine("Subject 2 : " + m2);
            Console.WriteLine("Subject 3 : " + m3);
            Console.WriteLine("Subject 4 : " + m4);
            Console.WriteLine("Subject 5 : " + m5);

        }
    }
}
