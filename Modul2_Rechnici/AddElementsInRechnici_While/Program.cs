using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElementsInRechnici_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> market = new Dictionary<string, int>();
            int s = 0;
            while (true)
            {

                Console.Write("stoka: ");
                string stoka = Console.ReadLine();
                if (stoka=="stop")
                {
                    break;
                }

                Console.Write("cena: ");
                int price = int.Parse(Console.ReadLine());

                market.Add(stoka, price);
            }
            Console.WriteLine("=====================");
            foreach (var item in market)
            {

                Console.WriteLine($"Stoka: {item.Key} : Cena {item.Value} lv");
                s += item.Value;
            }
            Console.WriteLine($"Suma: {s} lv");

        }
    }
}
