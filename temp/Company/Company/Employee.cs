using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Employee:Person
    {
        public int code;
        public Employee(int a, string n, string g, int c):base(a, n, g)
        {
            code = c;
        }
        public void display()
        {
            //System.Console.WriteLine(age+name+gender+code);
            System.Console.WriteLine("Name : " + name);
            System.Console.WriteLine("Age : " + age);
            System.Console.WriteLine("Gender : " + gender);
            System.Console.WriteLine("Code : " + code);
            System.Console.WriteLine("\n");
        }
    }
}
