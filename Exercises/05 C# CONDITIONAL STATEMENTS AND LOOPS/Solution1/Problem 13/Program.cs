using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            double fiftyPercentN = N / 2;
            int sum = 0;

            while (N>=M)
            {
                if (N == fiftyPercentN && Y !=0)
                {
                    N = N / Y;
                    continue;
                }
                sum++;
                N -= M;
                

            }
            Console.WriteLine(Math.Floor(N));
            Console.WriteLine(sum);
        }
    }
}
