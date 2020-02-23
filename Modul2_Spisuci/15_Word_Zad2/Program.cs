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
            int br = 0;


            while (num.Contains(a))
            {
                num.Remove(a);
                br++;
            }
                 
            
            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(br);




            //for (int i = 0; i < num.Count; i++)
            //{
            //    if (a==num[i])
            //    {
            //        num.Remove(num[i]);
            //    }

            //}



        }
    }
}
