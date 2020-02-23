using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisuk_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            num.Sort();
            int br = 0;

            foreach (var item in num)
            {
                
                if (item % 2 == 0)
                {

                    Console.WriteLine(item);
                    br++;
            
                }
              
            }
            Console.WriteLine(br);

        }
    }
}
