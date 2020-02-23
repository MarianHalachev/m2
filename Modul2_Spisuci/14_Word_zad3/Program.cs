using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Word_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            num.Sort();
            int Min = 0;
            int Max = 0;

            int minSpisak = num.Min();
            int maxSpisak = num.Max();

            Min = minSpisak;
            Max = maxSpisak;

            foreach (var item in num)
            {
                if (item==Min)
                {
                    Console.Write(Min + " ");
                }
            }

            foreach (var item in num)
            {
                if (item==Max)
                {
                    Console.Write(Max + " ");
                }
            }
            

            
        }
        
    }
}
