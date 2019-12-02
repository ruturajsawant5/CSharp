using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Current:Account
    {
        double bal;
        double pen = 100;
        

        public void setSavings(string n, string a, string t, double b)
        {
            base.setAccount(n, a, t);
            bal = b;
        }
        public void displayBal()
        {
            System.Console.WriteLine("\nBalance : " + bal);
        }
        public void withdraw(double d)
        {
            bal -= d;
            System.Console.WriteLine("\n" + d + " Withdrew\nUpdated Balance : " + bal);
        }
        public void deposit(double d)
        {
            bal += d;
            System.Console.WriteLine("\n" + d + " Deposited\nUpdated Balance : " + bal);
        }

        public void penalty()
        {
            if (bal < 1000)
            {
                bal -= pen;
                System.Console.WriteLine("\n" + pen + " deducted as penalty\nUpdated Balance : " + bal);
            }
        }

    }
}
