using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = hours * 3600 + minutes * 60 + seconds;
            float timeInHours=hours+((float)minutes/60)+((float)seconds /3600);

            float speedMetersInSecond = distanceInMeters / timeInSeconds;
            Console.WriteLine($"{speedMetersInSecond}");
            float speedKilometersInHour = (distanceInMeters / 1000) / timeInHours;
            Console.WriteLine(speedKilometersInHour);
            float speedMilesInHour = speedKilometersInHour / 1.609f;
            Console.WriteLine(speedMilesInHour);

            

        }
    }
}
