using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _12_REGEX_Remove_startend
{
    class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {

            string str = "m,ake ma,ze and , manas,ge to m,easure ,it";
            Console.WriteLine("before : "+str);

            string str1 = Regex.Replace(str, @"\s+", "");
             str1 = Regex.Replace(str1, @",+", "");

            Console.WriteLine("after : " + str1);


            Console.ReadKey();
        }
    }
}
