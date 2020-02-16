using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Word_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double p = 2 * a + 2 * b;
            double s = a * b;
             decimal d = (decimal)Math.Sqrt(a *a + b *b);
            decimal d1 = (decimal)Math.Sqrt(a * a + b * b);

            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(d);
            Console.WriteLine(d1);
        }
    }
}
