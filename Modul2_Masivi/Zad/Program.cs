using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6 };
            int sum = 0;

            for (int i = 0; i <num.Length; i++)
            {
                if (num[i]%2==0)
                {
                    sum = num[i] + sum;
                }
            }

            Console.WriteLine(sum);
           

            //foreach (var item in num)
            //{
            //    if (item%2==0)
            //    {

            //        Console.WriteLine(item);
            //        sum += item;
                   
            //    }
            //}
            //Console.WriteLine($"sum={sum}");
            
            
        }
    }
}
