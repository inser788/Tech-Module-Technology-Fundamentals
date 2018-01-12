using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine()) * 100;
            decimal width = decimal.Parse(Console.ReadLine());
            if (length==0||width==0)
            {
                Console.WriteLine("0.00");
                return;
            }
            var remainderAfterDev = length % width;
            if (remainderAfterDev==0)
            {
                Console.WriteLine($"{(length * width):f2}");
            }
            else
            {
                Console.WriteLine($"{(length/width*100m):f2}%");
            }

        }
    }
}
