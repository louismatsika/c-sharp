using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int i = 0;
            int x = 0;
            Console.WriteLine("how many times would you like to flip the coin ");
            x = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < x; i++)
            {
                int flip = rnd.Next(1, 3);
                if (flip == 1)
                {
                    Console.WriteLine("you flipped heads");
                }
                else if (flip == 2)
                {
                    Console.WriteLine("you flipped tails");
                }

            }

            Console.ReadLine();
        }
    }
}
