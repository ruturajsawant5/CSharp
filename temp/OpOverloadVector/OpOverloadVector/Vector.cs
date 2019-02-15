using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpOverloadVector
{
    public class Vector
    {
        int a, b, c;

        public Vector(int x, int y, int z)
        {
            a = x;
            b = y;
            c = z;
        }
        
        public void display()
        {
            System.Console.Write(a+" ");
            System.Console.Write(b + " ");
            System.Console.Write(c);

        }

        public static Vector operator+(Vector x, Vector y)
        {
            Vector res = new Vector(0, 0, 0);
            res.a=x.a+y.a;
            res.b=x.b+y.b;
            res.c=x.c+y.c;
            return res;
        }

        public static Vector operator *(int x, Vector y)
        {
            Vector res = new Vector(0, 0, 0);
            res.a = x * y.a;
            res.b = x * y.b;
            res.c = x * y.c;
            return res;
        }

        public static Vector operator *(Vector y,int x)
        {
            Vector res = new Vector(0, 0, 0);
            res.a = x * y.a;
            res.b = x * y.b;
            res.c = x * y.c;
            return res;
        }

        public static int operator *(Vector x, Vector y)
        {
            Vector res = new Vector(0, 0, 0);
            res.a = x.a * y.a;
            res.b = x.b * y.b;
            res.c = x.c * y.c;
            return (res.a+res.b+res.c);
        }

    }
}
