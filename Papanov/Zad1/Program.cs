using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary < double, double> number = new SortedDictionary<double, double>();
            
            foreach (var item in numbers)
            {
                if (number.ContainsKey(item))
                {
                   number[item]+=1;
                }
                else
                {
                    number[item] = 1;
                }
               

            }
            foreach (var item in number)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
