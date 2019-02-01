using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hi
{
    interface Addition
    {
        int Add();
    }
    interface Multiplication
    {
        int mul();
    }
    class Computation : Addition, Multiplication
    {
        int x, y;
        public Computation(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Add()
        {
            return (x + y);
        }
        public int mul()
        {
            return (x * y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computation c = new Computation(10,20);
            Console.WriteLine(c.Add());
             Console.WriteLine(c.mul());
            Console.ReadLine();

        }
    }
}
