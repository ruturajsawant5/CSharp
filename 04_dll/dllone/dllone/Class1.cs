using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = System.Console;

namespace dllone
{
    public class Class1
    {
        int a, b;
        public void add()
        {
            D.WriteLine("Enter Numbers to add : ");
            a=Convert.ToInt32(D.ReadLine());
            b=Convert.ToInt32(D.ReadLine());
            D.WriteLine("Result : "+(a + b));
        }
    }
}
