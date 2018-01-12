using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripDistanceMiles = double.Parse(Console.ReadLine());
            double tankCapacity = double.Parse(Console.ReadLine());
            double milesInHeavyWinds = double.Parse(Console.ReadLine());

            double normalMilesFuel = (tripDistanceMiles - milesInHeavyWinds) * 25.0;
            double heavyWindFuel = milesInHeavyWinds*(1.5 * 25);
            double fuelTotal = (normalMilesFuel + heavyWindFuel) * 1.05;
            Console.WriteLine($"Fuel needed: {fuelTotal:f2}L");
            double moreLessFuel = tankCapacity - fuelTotal;
            if (moreLessFuel>=0)
            {
                Console.WriteLine($"Enough with {moreLessFuel:f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {-moreLessFuel:f2}L more fuel.");
            }
        }
    }
}
