using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Savings:Account
    {
        double bal;
        double interest = 5.5;
    
        public void setSavings(string n, string a, string t,double b)
        {
            base.setAccount(n,a,t);
            bal = b;
        }
        public void displayBal()
        {
            System.Console.WriteLine("\nBalance : " + bal);
        }
        public void withdraw(double d)
        {
            bal -= d;
            System.Console.WriteLine("\n"+d+" Withdrew\nUpdated Balance : " + bal);
        }
        public void deposit(double d)
        {
            bal += d;
            System.Console.WriteLine("\n" + d + " Deposited\nUpdated Balance : " + bal);
        }
        public void calcInterest()
        {
            double intetestamt = bal * interest / 100;
            bal += intetestamt;
           System.Console.WriteLine("\n" + intetestamt + " added as interest\nUpdated Balance : " + bal);
        }
    }
}
