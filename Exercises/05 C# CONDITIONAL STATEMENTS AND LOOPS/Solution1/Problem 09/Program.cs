using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiple = 0;

            for (int i = 1; i <= 10; i++)
            {
                multiple = n * i;
                Console.WriteLine($"{n} X {i} = {multiple}");
            }
        }
    }
}
