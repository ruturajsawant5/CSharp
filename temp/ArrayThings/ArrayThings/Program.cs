using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = System.Console;

namespace ArrayThings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[] {10,9,8,7,4,5,6,3,2,1};

            int l1 = arr.GetLength(0);

            D.WriteLine("Length of array is "+l1);


            D.WriteLine("Contents of array are : ");
            for (int i = 0; i < (arr.Length); i++)
            {
                D.Write(arr.GetValue(i));
                D.Write("\t");
            }
            Array.Sort(arr);
            D.WriteLine("Sort Contents of array are : ");
            for (int i = 0; i < (arr.Length); i++)
            {
                D.Write(arr.GetValue(i));
                D.Write("\t");
            }
            Array.Reverse(arr);
            D.WriteLine("Reversed Contents of array are : ");
            for (int i = 0; i < (arr.Length); i++)
            {
                D.Write(arr.GetValue(i));
                D.Write("\t");
            }

            int[] arr2 = new int[10];
            Array.Copy(arr,0,arr2,0,10);
            D.WriteLine("Copy Contents of array are : ");
            for (int i = 0; i < (arr2.Length); i++)
            {
                D.Write(arr2.GetValue(i));
                D.Write("\t");
            }

           

            D.ReadKey();
        }
    }
}
