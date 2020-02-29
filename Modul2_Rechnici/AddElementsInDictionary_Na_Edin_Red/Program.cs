using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElementsInDictionary_Na_Edin_Red
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> a = new Dictionary<string, int>();
            var linia = Console.ReadLine().Split();

            while (true)
            {
                string stoka = linia[0];
                if (stoka=="stop")
                {
                    break; 
                }

                int price = int.Parse(linia[1]);

                if (a.ContainsKey(stoka))
                {
                    a[stoka] = price + price;
                }
                else
                {
                    a.Add(stoka, price);
                }

                

                linia = Console.ReadLine().Split();

            }
            foreach (var item in a)
            {
                Console.WriteLine($"{item.Key} => {item.Value} lv ");
            }

        }
    }
}
