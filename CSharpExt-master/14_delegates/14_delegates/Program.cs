using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_delegates
{
    public delegate void mydele(int x, int y);
    public delegate void myMultiDele(int x, int y);

    class A
    {
        public void add(int x, int y)
        {
            Console.WriteLine("The Sum is " + (x + y));
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("The Difference is " + (x - y));
            
        }
    }
    


    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            //make an object of class A 
            mydele m = new mydele(obj.add);
            m(10, 20);
            mydele m1 = new mydele(obj.sub);
            m1(10, 20);

            A b1 = new A();
            //make an object of class A 
            myMultiDele Md = new myMultiDele(b1.add);
            myMultiDele Md1 = new myMultiDele(b1.sub);
            Md = Md + Md1;
            Md(60, 90);
            Console.ReadKey();
        }
    }
}
