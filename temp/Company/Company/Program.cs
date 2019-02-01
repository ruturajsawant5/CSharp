using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Employee");
            Employee[] emp = new Employee[3] ;
            emp[0] = new Employee(21, "Siddhi Jadhav", "Male", 3);
            emp[0].display();
            emp[1] = new Employee(20, "Ruturaj Desai", "Male", 1);
            emp[1].display();
            emp[2] = new Employee(19, "Ruturaj Desai", "Male", 2);
            emp[2].display();

            System.Console.WriteLine("Specialist");
            Specialist[] spl = new Specialist[3];
            spl[0] = new Specialist(21, "Siddhi Jadhav", "Male", 3);
            spl[0].display();
            spl[1] = new Specialist(20, "Ruturaj Desai", "Male", 1);
            spl[1].display();
            spl[2] = new Specialist(19, "Ruturaj Desai", "Male", 2);
            spl[2].display();

            System.Console.ReadKey();
        }
    }
}