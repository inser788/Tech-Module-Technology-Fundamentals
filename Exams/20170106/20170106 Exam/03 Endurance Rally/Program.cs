using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] driverNames = Console.ReadLine()
                .Split().ToArray();

            double[] track = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            int[] checkpointIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (driverNames.Length == 0)
                return;

            for (int i = 0; i < driverNames.Length; i++)
            {
                string driverName = driverNames[i];
                double currentDriverFuel = driverNames[i].ToCharArray().First();
                for (int j = 0; j < track.Length; j++)
                {
                    double currentZone = track[j];
                    if (checkpointIndexes.Contains(j))
                    {
                        currentDriverFuel += currentZone;
                    }
                    else
                    {
                        currentDriverFuel -= currentZone;
                    }
                    if (currentDriverFuel <= 0)
                    {
                        Console.WriteLine($"{driverName} - reached {j}");
                        break;
                    }
                }
                if(currentDriverFuel>0)
                Console.WriteLine($"{driverName} - fuel left {currentDriverFuel:f2}");
            }
        }
    }
}
