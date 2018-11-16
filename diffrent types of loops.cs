using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string again;
            for (i = 0; i < 1; i++)
            {
                Console.WriteLine("hello");
            }

            again = "y";
            while (again == "y")
            {
                Console.WriteLine("hello");
                Console.Write("again?  ");
                again = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("hello");
                Console.Write("again?");
                again = Console.ReadLine();
            } while (again == "y");

            Console.ReadLine();
        }
    }
}
