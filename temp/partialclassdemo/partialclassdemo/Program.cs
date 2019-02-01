using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclassdemo
{
 public partial  class calc
    {
     public int a, b, c;
     public void get()
     {
         Console.WriteLine("Enter the 2 numbers:");
         a = Convert.ToInt32(Console.ReadLine());
         b = Convert.ToInt32(Console.ReadLine());

     }
     }
}
