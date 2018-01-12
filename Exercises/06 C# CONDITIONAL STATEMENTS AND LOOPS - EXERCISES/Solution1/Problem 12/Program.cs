using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxBoundarySum = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    //Console.WriteLine($"{i} {j} ");
                    sum += 3 * (i * j);
                    //Console.WriteLine(sum);
                    count++;
                    if (sum>=maxBoundarySum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxBoundarySum}");
                        return;
                    }
                    
                }
            }
            if (sum < maxBoundarySum)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }


        }
    }
}
