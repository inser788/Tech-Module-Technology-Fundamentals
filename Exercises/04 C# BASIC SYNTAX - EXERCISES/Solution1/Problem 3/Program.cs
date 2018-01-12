using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {

            double miles = double.Parse(Console.ReadLine());

            double kilometrers = miles * 1.60934;

            Console.WriteLine($"{kilometrers:f2}");
        }
    }
}
