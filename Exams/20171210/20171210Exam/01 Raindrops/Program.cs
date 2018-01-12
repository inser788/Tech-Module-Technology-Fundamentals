using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int amoutOfRegions = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());

            double sumAllRain = 0.0;

            for (int i = 0; i < amoutOfRegions; i++)
            {
                string[] regionData = Console.ReadLine()
                    .Split()
                    .ToArray();
                long raindropsCount = long.Parse(regionData.First());
                double squareMeters = double.Parse(regionData.Last());

                double regionalCofficient = raindropsCount / squareMeters;

                sumAllRain += regionalCofficient;
            }
            if (density==0)
            {
                Console.WriteLine($"{sumAllRain:f3}");
                return;
            }
            Console.WriteLine($"{(sumAllRain/density):f3}");
        }
    }
}
