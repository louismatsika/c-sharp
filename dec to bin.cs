using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1;
            string x;

            Console.Write("enter a number ");
            num1 = Console.ReadLine();

            int num = Convert.ToInt32(num1);
            x = "";
            while (num > 1)
            {
                int remainder = num % 2;
                x = Convert.ToString(remainder) + x;
                num /= 2;
            }
            x = Convert.ToString(num) + x;
            Console.WriteLine("");
            Console.WriteLine("that number in binaray is {0}", x);
            Console.ReadLine();
        }
    }
}
