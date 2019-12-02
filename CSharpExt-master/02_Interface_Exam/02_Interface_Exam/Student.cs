using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface_Exam
{
    class Student:Exam
    {
        string name;
        int rollNo, mark1, mark2;

        public Student(int r, string n, int m1, int m2)
        {
            rollNo = r;
            name = n;
            mark1 = m1;
            mark2 = m2;
        }
        public void percent_cal()
        {
            Console.WriteLine("Percentage"+ ((mark1+mark2)/2.0));
        }

        public void display()
        {
            Console.WriteLine("Roll No : "+rollNo);
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Mark 1 : "+mark1);
            Console.WriteLine("Mark 2 :"+mark2);
        }


    }
}
