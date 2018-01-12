using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountBirds = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountBirds; i++)
            {
                var yearRebirth = 0.0m;
                long length = long.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                long wingslength = long.Parse(Console.ReadLine()) * 2;
                yearRebirth = (length * length) * (width + wingslength);
                Console.WriteLine(yearRebirth);
            }
        }
    }
}
