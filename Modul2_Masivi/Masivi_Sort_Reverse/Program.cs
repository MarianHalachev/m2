using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masivi_Sort_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 5, 8, 234 };

            int sum = num.Sum();

            Console.WriteLine(sum);

            //Sort
            Array.Sort(num);
            Console.WriteLine(string.Join(" ", num));

            foreach (var item in num)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]+" ");
            }
            Console.WriteLine();
            //Reverse
            Array.Reverse(num);
            Console.Write(string.Join("|", num));
        }
    }
}
