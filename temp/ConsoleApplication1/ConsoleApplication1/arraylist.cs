using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            int[] a2 = new int[5];
            al.Add(50);
            al.Add(36);
            al.Add(11);
            al.Add(25);
            al.Add(5);
            al.Remove(5);
            al.Insert(2,3);
            
            al.CopyTo(12,a2,15,23);
            al.Sort();
            bool y = al.contain(4);
            al.Clear();
            int c= al.Capacity;
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.WriteLine();
            Console.WriteLine.
        }
    }
}
