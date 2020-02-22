using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Word_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] alphabet = new char[30];
            int a = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[a]= i;
                a++;
            }
            Console.WriteLine(string.Join(" ", alphabet ));

            Console.WriteLine("Vavedete duma: ");
            string word = Console.ReadLine();
            for (int i = 0; i <word.Length; i++)
            {
                for (int k = 0; k < alphabet.Length; k++)
                {
                    if (word[i] == alphabet[k])
                    {
                        Console.WriteLine($"{word[i]} -> {k}");
                    }
                }
            }
           


        }
    }
}
