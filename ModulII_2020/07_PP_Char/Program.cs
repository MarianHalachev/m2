using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PP_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            //char a = 'z';
            //Console.WriteLine($"{a} = {(int)a} ");

            //int a1 = 122;
            //Console.WriteLine($"{a1} = {(char)a1}");


            //for (char i = 'A'; i <= 'Z'; i++)
            //{
            //    Console.WriteLine($"{i} = {(int)i}");
            //}

            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    for (int K = 0; K < a; K++)
                    {
                        char letter1 = (char)('a' + i);
                        char letter2 = (char)('a' + j);
                        char letter3 = (char)('a' + K);
                        Console.WriteLine($"{letter1}, {letter2}, {letter3}");
                    }
                    
                }
            }
        }

    }
}
