using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PP_Zad2_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }

            //Обръщане на елементи на масив
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
