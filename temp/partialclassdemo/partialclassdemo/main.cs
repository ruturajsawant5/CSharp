using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclassdemo
{
    public partial class calc
    {
        public static void Main()
        {
            calc a1 = new calc();
            a1.get();
            a1.display();
            Console.ReadLine();
        }
    }
}
