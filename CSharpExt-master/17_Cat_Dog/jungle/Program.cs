using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jungle
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Cat");
            Cat cat = new Cat("rusty", 11);
            cat.display();

            System.Console.WriteLine("\nDog");
            Dog dog = new Dog("tater", 6);
            dog.display();
            System.Console.ReadKey();
        }
    }
}
