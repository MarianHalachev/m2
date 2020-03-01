using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Word_Zad2_TelefonenUkazatel
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
           
            while (true)
            {
                var linia = Console.ReadLine().Split().ToList();
                var command = linia[0];
                
                if (command=="END")
                {
                    break;
                }
                if (command=="A")
                {

                    var name = linia[1];
                    var number = linia[2];

                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = number;
                    }

                    else
                    {
                        phonebook.Add(name, number);
                    }
                    
                }
                if (command=="S")
                {
                    var name = linia[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist");
                    }

                }
                                             

            }
            foreach (var item in phonebook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
