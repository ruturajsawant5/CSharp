using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = System.Console;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[2];
            arr[2] = new int[1];


            D.WriteLine("Enter Elements :");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = 0;
                    //arr[i][j] = Convert.ToInt32(D.ReadLine());
                }
            }

            D.WriteLine("Entered Elements are :");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < (arr[i].Length); j++)
                {
                    D.Write(arr[i][j]);
                    D.Write('\t');
                }
                D.WriteLine();
            }




            D.ReadKey();
    
        }
    }
}



