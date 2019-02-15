using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpOverloadMystring
{
    public class MyString
    {
        public string s1;

        public MyString(string x)
        {
            s1 = x;
        }

        public void display()
        {
            System.Console.WriteLine(s1);
        }

        public static MyString operator +(MyString x, MyString y)
        {
            MyString res = new MyString("");
            res.s1 = x.s1 + y.s1;
            return res;
        }

        public static bool operator -(MyString x)
        {
            bool res = false;
            if (x.s1 == "")
                res = true;
            return res;
        }
        
    }
}
