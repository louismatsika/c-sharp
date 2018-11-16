using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxsize = 7;
            string[] mark = new string[maxsize];
            for (int i = 0; i < maxsize; i++)
            {
                Console.WriteLine("enter a mark");
                mark[i] = Console.ReadLine();
            }
            Console.WriteLine(mark[0-6]);

            Console.ReadLine();
        }
    }
}
