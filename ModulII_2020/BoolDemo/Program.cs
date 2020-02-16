using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            bool flag;
            //flag = a > b;
            //flag = a==b;
            flag = a < b;

            Console.WriteLine(flag);
        }
    }
}
