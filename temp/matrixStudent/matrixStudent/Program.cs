using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = System.Console;
namespace matrixStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] result = new int[5,5];
            for (int i = 0; i < 5; i++)
            {
                D.WriteLine("Enter RollNo and Marks of Student "+(i+1)+" :");
                result[i,0]=Convert.ToInt32(D.ReadLine());
                result[i,1]=Convert.ToInt32(D.ReadLine());
                result[i,2]=Convert.ToInt32(D.ReadLine());
                result[i,3] = Convert.ToInt32(D.ReadLine());
            }

            D.WriteLine("\n\nTotal Marks Obtained By each Student:");
            for (int i = 0; i < 5; i++)
            {
                D.Write("Student " + result[i,0]+" : ");
                int total = 0;
                total = result[i, 1] + result[i, 2] + result[i, 3];
                result[i, 4] = total;
                D.Write(total);
                D.WriteLine();
            }

            //highest mark thing
            D.WriteLine("\n\nHighest Mark in Each Subject:");
            for (int i = 1; i <= 3; i++)
            {
                D.Write("Subject " + i + " : ");
                int high = result[0,i];
                int highroll = result[0,0];
                for (int j = 1; j < 5; j++)
                {
                    if (high < result[j, i])
                    {
                        high = result[j, i];
                        highroll = result[j, 0];
                    }
                }
                D.Write(" High Marks : " + high  + " Roll No : " + highroll);
                D.WriteLine();
            }

            //high total thing
            int hightot = result[0, 4];
            int hightotroll =result[0, 0];
            for (int i = 1; i < 5; i++)
            {
                if(hightot<result[i,4])
                {
                    hightot = result[i, 4];
                    hightotroll = result[i, 0];
                }
            }
            D.WriteLine("\n\nThe highest total of marks is "+hightot+" obtained by roll number "+hightotroll);

            D.ReadKey();
        }
    }
}
