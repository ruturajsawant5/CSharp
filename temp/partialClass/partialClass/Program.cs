using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialClass
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.add();
            p1.sub();
            p1.mul();
            p1.div();
            System.Console.ReadKey();
        }
    }
}
