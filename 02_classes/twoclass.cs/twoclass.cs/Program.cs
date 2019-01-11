using System;


namespace twoclass.cs
{
    class one
    {
        string str;
        public one()
        {
             str = "C # ";
        }
        
        public void display()
        {
            System.Console.Write(str);
        }
    }

    class two
    {
        string str;
        public two()
        {
            str = "Programming";
        }
        public void display()
        {
            System.Console.Write(str);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            one ob1 = new one();
            ob1.display();

            two ob2 = new two();
            ob2.display();


            System.Console.ReadKey();
        }
    }
}
