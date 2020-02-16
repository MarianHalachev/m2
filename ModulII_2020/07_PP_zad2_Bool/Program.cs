using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PP_zad2_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            Convert.ToBoolean(a);

            if (a=="true ")
            {
                Console.WriteLine("Yes");
            }
            if (a=="false")
            {
                Console.WriteLine("No");
            }
        }
    }
}
