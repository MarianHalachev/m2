using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PP_Char1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int ost = 0;
            int s = 0;

            for (int i = 0; i < n; i++)
            {
                s = 0;
                int chislo = i;

                while (chislo>0)
                {
                    ost = chislo % 10;
                    chislo = chislo / 10;
                    s = s + ost;
                }

                bool flag = (s == 5 || s == 7 || s == 11);
                Console.WriteLine($"{flag} {i}");

            }
        }
    }
}
