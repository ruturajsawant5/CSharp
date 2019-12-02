using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _10_REGEX_m._.e
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

            string str = "make maze and manage to measure it";
            Console.WriteLine("Matching words start with 'd' and ends with 't':");
            showMatch(str, @"\bm\S*e\b");
            Console.ReadKey();
        }
    }
}
