using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Word_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minior = new Dictionary<string, int>();
            while (true)
            {
                string material = Console.ReadLine();
                if (material=="stop")
                {
                    break;

                }
                int price = int.Parse(Console.ReadLine());
                

                if (minior.ContainsKey(material))
                {
                    minior[material] += price ;
                }
                else
                {
                    minior.Add(material, price);
                }

            }
            
            foreach (var item in minior)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
