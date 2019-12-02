using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpOverloadMystring
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString a1 = new MyString("Hello");
            System.Console.Write("a1 : ");
            a1.display();

            MyString a2 = new MyString(" World");
            System.Console.Write("a2 : ");
            a2.display();

            MyString a3 = a1+a2;
            System.Console.Write("a1+a2 : ");
            a3.display();


            bool r1 = -a1;
            System.Console.Write("-a1 : ");
            System.Console.WriteLine(r1);

            MyString a4 = new MyString("");
            System.Console.Write("a4 : ");
            a4.display();
            bool r2 = -a4;
            System.Console.Write("-a4 : ");
            System.Console.WriteLine(r2);


            System.Console.ReadKey();
        }
    }
}
