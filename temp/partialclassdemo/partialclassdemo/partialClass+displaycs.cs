using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclassdemo
{
   public partial class calc
    {
       public void display()
       {
           c = a + b;
           Console.WriteLine("The result is="+c);
           Console.ReadLine();
       }
    }
}
