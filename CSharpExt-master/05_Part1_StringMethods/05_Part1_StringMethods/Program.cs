using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Part1_StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1 = "    Lorem ipsum dolor sit amet     ";

            Console.WriteLine("String : " + str1);

            Console.WriteLine("Length : " + str1.Length);

            Console.WriteLine("CompareTo : "+str1.CompareTo("Sed pretium, est non tempus tincidunt"));

            Console.WriteLine("UpperCase : " + str1.ToUpper());

            Console.WriteLine("Trim : " + str1.Trim());

            string str2 = "xxxxxxxx";

            string str3 = String.Concat(str1, str2);

            Console.WriteLine("Concat : " + str3);

            string substr = str1.Substring(7);
            Console.WriteLine("SubString : "+substr);

            str1=str1.Insert(7, "ruturaj");

            Console.WriteLine("Insert : " + str1);

            Console.ReadLine();

        }
    }
}
