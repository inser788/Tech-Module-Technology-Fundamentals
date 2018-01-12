using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var array = new long[n];
            array[0] = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    if (i-j>=0)
                    {
                        array[i] += array[i-j];
                    }
                }
            }
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
