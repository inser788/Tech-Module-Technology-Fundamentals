using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(number));
        }

        static long Fib(int n)
        {
            if (n < 2)
            {
                return 1L;
            }

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
