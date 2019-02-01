using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = System.Console;
namespace MatrixASM
{
    class Program
    {
        static void Main(string[] args)
        {
            D.WriteLine("Enter Number of rows:");
            int T = Convert.ToInt32(D.ReadLine());
            int[,] mat1 = new int[T,T];
            int[,] mat2 = new int[T,T];

            D.WriteLine("Enter First Array :");
            for(int i=0;i<T;i++)
                for(int j=0;j<T;j++)
                    mat1[i,j]=Convert.ToInt32(D.ReadLine());
        
            D.WriteLine("Enter Second Array :");
            for (int i = 0; i < T; i++)
                for (int j = 0; j < T; j++)
                    mat2[i, j] = Convert.ToInt32(D.ReadLine());

            int[,] add = new int[T, T];
            for (int i = 0; i < T; i++)
                for (int j = 0; j < T; j++)
                    add[i,j] = mat1[i,j]+mat2[i,j];

            D.WriteLine("The First Matrix is");
            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < T; j++)
                {
                    D.Write(mat1[i, j]);
                    D.Write("\t");
                }
                D.WriteLine();
            }
            D.WriteLine("The Second Matrix is");
            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < T; j++)
                {
                    D.Write(mat2[i, j]);
                    D.Write("\t");
                }
                D.WriteLine();
            }

            D.WriteLine("The Addition of Matrices is");
            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < T; j++)
                {
                    D.Write(add[i, j]);
                    D.Write("\t");
                }
                D.WriteLine();
            }


            int[,] sub = new int[T, T];
            for (int i = 0; i < T; i++)
                for (int j = 0; j < T; j++)
                    sub[i,j] = mat1[i,j]-mat2[i,j];

            D.WriteLine("The Substraction of Matrices is");
            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < T; j++)
                {
                    D.Write(sub[i, j]);
                    D.Write("\t");
                }
                D.WriteLine();
            }


            int[,] mul = new int[T, T];
            for (int i = 0; i < T; i++) {
                for (int j = 0; j < T; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < T; k++) 
                    { 
                        temp = temp + (mat1[i,k]*mat2[k,j]);
                    }
                    mul[i, j] = temp;
                }
            }
            
            D.WriteLine("The Multiplication of Matrices is");
            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < T; j++)
                {
                    D.Write(mul[i, j]);
                    D.Write("\t");
                }
                D.WriteLine();
            }



            D.ReadKey();
        }
    }
}
