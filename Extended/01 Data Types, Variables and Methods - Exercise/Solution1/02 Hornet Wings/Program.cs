using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            double traveledMeters = (wingFlaps / 1000.0) * distanceInMeters;
            double secondsForFlaps = wingFlaps / 100.0;
            double restSeconds = (wingFlaps / endurance ) * 5;
            double sumSeconds = secondsForFlaps + restSeconds;
            Console.WriteLine($"{traveledMeters:f2} m.");
            Console.WriteLine($"{sumSeconds} s.");
        }
    }
}
