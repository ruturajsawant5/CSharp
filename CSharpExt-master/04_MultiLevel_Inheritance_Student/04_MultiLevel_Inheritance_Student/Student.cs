using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MultiLevel_Inheritance_Student
{
    class Student
    {
        public string name;
        public int roll;
        public Student(int r, string n)
        {
            roll = r;
            name = n;
        }
        public void display()
        {
            Console.WriteLine("Roll No : "+ roll);
            Console.WriteLine("Name : "+ name);

        }
    }
}
