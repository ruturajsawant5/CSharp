using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        string name;
        string ac_no;
        string type;

        public void setAccount(string n, string a, string t)
        {
            name = n;
            ac_no = a;
            type = t;
        }

    }
}
