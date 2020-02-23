using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Word_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            num.Reverse();

            for (int i = 0; i < num.Count; i++)
            {

                if (num[i]<0)
                {
                    num.Remove(num[i]);
                }

                
            }
           
           
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
