using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListThings
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            
            al.Add(10);
            al.Add(11);
            al.Add(19);
            al.Add(17);
            al.Add(1);
            System.Console.WriteLine("The Contents of arraylis are : ");
            for (int i = 0; i < al.Count; i++)
            {
                System.Console.Write(al[i]);
                System.Console.Write("\t");
            }
            System.Console.WriteLine("\n\n");
            al.Insert(3, 99);

            int j = 10, l = 1000;
            if (al.Contains(j))
                System.Console.WriteLine(j + " is found in arraylist at position "+(al.IndexOf(j)));
            else
                System.Console.WriteLine(j + " is not found in arraylist");
            if (al.Contains(l))
                System.Console.WriteLine(l + " is found in arraylist at position "+(al.IndexOf(l)));
            else
                System.Console.WriteLine(l + " is not found in arraylist");


            al.Sort();
            System.Console.WriteLine("\n\nSorted elements of arraylist is :");
            for (int i = 0; i < al.Count; i++)
            {
                System.Console.Write(al[i]);
                System.Console.Write("\t");
            }
            System.Console.WriteLine();


            al.Clear();
            System.Console.ReadKey();

        }
    }
}
