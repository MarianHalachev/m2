using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Word_Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int a = num[num.Count-1];
            for (int i = 0; i < num.Count; i++)
            {
                if (a==num[i])
                {
                    num.Remove(num[i]);
                }

            }
            Console.WriteLine(string.Join(" ",num));
         
            
        }
    }
}
