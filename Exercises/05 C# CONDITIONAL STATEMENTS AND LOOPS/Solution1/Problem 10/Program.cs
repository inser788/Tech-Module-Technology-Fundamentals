using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int multiple2 = n * m;
            int multiple = 0;
            if (m>10)
            {
                Console.WriteLine($"{n} X {m} = {multiple2}");
            }

            for (int i = m; i <= 10; i++)
            {
                multiple = n * i;
                Console.WriteLine($"{n} X {i} = {multiple}");
            }

        }
    }
}
