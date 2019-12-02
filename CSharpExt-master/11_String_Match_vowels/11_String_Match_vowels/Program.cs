using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_String_Match_vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter STring :");
            str = Console.ReadLine();
            Console.WriteLine("Length : " + str.Length);

            Console.WriteLine("Reverse : " +String.Join(" ", str.Split(' ').Reverse()));

            int total = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    total++;
                }
            }
            Console.WriteLine("Vowels : " + total);

            Console.ReadLine();
        }
    }
}
