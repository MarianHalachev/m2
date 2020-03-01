using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Word_Zad2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                var linia = Console.ReadLine().Split().ToList();
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                if (command=="A")
                {
                    
                }






            }
        }
    }
}
