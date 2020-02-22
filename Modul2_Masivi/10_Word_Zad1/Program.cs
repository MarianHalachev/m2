using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Word_Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", num));

            int sum = num.Sum();
            Console.WriteLine($"sum= {sum}");

            int max = num.Max();
            Console.WriteLine($"max= {max}");

            int min = num.Min();
            Console.WriteLine($"min= {min}");
                        
            double avg = num.Average();
            Console.WriteLine($"average= {avg:f2}");
        }
    }
}
