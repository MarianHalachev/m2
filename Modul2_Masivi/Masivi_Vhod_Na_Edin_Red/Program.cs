using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masivi_Vhod_Na_Edin_Red
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
             string[] num = Console.ReadLine().Split(' ').ToArray();


            Console.WriteLine("=================");
            Console.WriteLine("=======FOR=======");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}]={num[i]} ");
            }

            /////////////////////////////////////////

            Console.WriteLine("====================");
            Console.WriteLine("=======FOREACH======");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            ///////////////////////////////////////////

            Console.WriteLine("=======================");
            Console.WriteLine("======string.Join======");
            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine("=======================");
        }
    }
}
