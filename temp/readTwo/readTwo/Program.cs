using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            System.Console.WriteLine("Enter Two Strings :");
            s1 = System.Console.ReadLine();
            s2 = System.Console.ReadLine();

            

            System.Console.WriteLine("The Entered Strings are :");
            System.Console.Write(s1 +' '+ s2);

            System.Console.ReadKey();
        }
    }
}
