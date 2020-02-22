using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_PP_Masiv_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi den ot sedmicata kato chislo: ");
            int day = int.Parse(Console.ReadLine());

            string[] days = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };

            if (day>=1 && day <=7)
            {
                Console.WriteLine(days[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
