using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Rechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> person = new Dictionary<string, int>
            {
                {"Hristo", 22},
                {"Gosho",32},
                {"Pesho", 21},
                {"Asen", 33},
                {"Marian", 17},
                {"Mecana", 81},
            };
            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}: {item.Value} age");

            }
            var sortPerson = person.OrderBy(x => x.Key);
            Console.WriteLine("=====================");

            foreach (var item in sortPerson)
            {
                Console.WriteLine($"{item.Key}: {item.Value} age");
            }

            var sortAgeDes = person.OrderByDescending(x => x.Value);
            Console.WriteLine("=====================");
            foreach (var item in sortAgeDes)
            {
                Console.WriteLine($"{item.Key}: {item.Value} age");
            }
        }
    }
}
