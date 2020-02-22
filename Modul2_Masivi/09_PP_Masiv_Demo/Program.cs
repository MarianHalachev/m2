using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_PP_Masiv_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"num[{i}]= ");
                num[i] = int.Parse(Console.ReadLine());

            }
           
            Console.WriteLine();
            Console.WriteLine("=======FOR=======");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}]={num[i]} ");
            }
            
            Console.WriteLine();
            Console.WriteLine("=======FOREACH======");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine();
            Console.WriteLine("======string.Join======");
            Console.WriteLine(string.Join(" ",num));


            ///////////////////////////////////////////////
            

            //int[] num1 = new int[] { 3, 5, 6, -7, 8 };

            ////Console.WriteLine(num[0]);
            ////Console.WriteLine(num1[2]);

            //int[] num2 = {1,2,3,4,5};
            ////Console.WriteLine(num2[2]);

            //string[] days = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            //Console.WriteLine(days[2]);
        }
    }
}
