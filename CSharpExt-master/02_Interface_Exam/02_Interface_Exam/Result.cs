using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface_Exam
{
    class Result:Student,Exam
    {
        public Result(int r, string n, int m1, int m2):base(r,n,m1,m2)
        {
        }
        public void percent_cal()
        {
            base.percent_cal();
        }

    }
}
