using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jungle
{
    public class Animal
    {
        string name;
        int age;
        public Animal(string n,int a)
        {
            name = n;
            age = a;
        }
        public void display()
        {
            System.Console.WriteLine("Name : " + name);
            System.Console.WriteLine("Age : " + age);
        }
    }
}
