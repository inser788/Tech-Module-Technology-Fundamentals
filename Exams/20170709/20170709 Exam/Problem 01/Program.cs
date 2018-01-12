using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01
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

            while (N >= M)
            {

                sum++;
                N -= M;
                if (N == fiftyPercentN && Y != 0)
                {
                    N = N / Y;
                    continue;
                }

            }
            Console.WriteLine(Math.Floor(N));
            Console.WriteLine(sum);
        }
    }
}
