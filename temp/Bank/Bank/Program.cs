using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Savings s1 = new Savings();
            System.Console.Write("Savings");
            s1.setSavings("Siddhi", "123", "Savings", 100);
            s1.displayBal();
            s1.withdraw(50);
            s1.deposit(500);
            s1.calcInterest();
            
            System.Console.WriteLine("\nCurrent");
            Current c1 = new Current();
            c1.setSavings("Siddhi", "123", "Savings", 5000);
            c1.displayBal();
            c1.withdraw(50);
            c1.deposit(500);
            c1.penalty();
            

            System.Console.ReadKey();
        }
    }
}
