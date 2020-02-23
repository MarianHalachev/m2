using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnogomeren_Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Двумерен масив
            int[,] num = new int[2,3];
            int[,] num1 = { { 1, 2, 3 }, { 4, 5, 6 }, };
           
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"num[{i}, {j}]=");
                    num[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //печат на масив
            for (int i = 0; i < 2; i++)
            {
                double sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"num[{i}, {j}]={num[i,j]} ");
                     sum=+ num[i,j];
                    
                }
                Console.WriteLine();
                double avg = sum / 3;
                Console.WriteLine(avg);
                

            } 
            
        }
    }
}
