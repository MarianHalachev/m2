using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElementInRechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            Console.Write("Broi Elementi : ");
            int brEl = int.Parse(Console.ReadLine());

            for (int i = 0; i < brEl; i++)
            {
                Console.Write("Ime: ");
                string name = Console.ReadLine();
                Console.Write("Nomer: ");
                string number = Console.ReadLine();


                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }
                else
                {
                    phonebook.Add(name, number);
                }
               
            }

            foreach (var item in phonebook)
            {
                Console.WriteLine($"ime: {item.Key} => nomer: {item.Value}");
            }
            Console.WriteLine("==============================");
            phonebook.Remove("Asen");
            Console.WriteLine(string.Join(" ", phonebook));

            int count = phonebook.Count;
            Console.WriteLine($"Broi: {count}");
        }
    }
}
