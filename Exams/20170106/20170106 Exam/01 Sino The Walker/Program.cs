using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var leavingTime = Console.ReadLine().Split(new char[] { ':' }).ToArray();
            long stepsToHome = long.Parse(Console.ReadLine());
            long secondsForStep = long.Parse(Console.ReadLine());
            long allTimeInSeconds = stepsToHome * secondsForStep;
            int hours = int.Parse(leavingTime[0]);
            int minutes = int.Parse(leavingTime[1]);
            int seconds = int.Parse(leavingTime[2]);
            int secondsLeaving = seconds + (60 * minutes) + (3600 * hours);
            long secondsWithOutDays = allTimeInSeconds % (24*3600);
            long secondsAll = secondsLeaving + secondsWithOutDays;
            TimeSpan time = TimeSpan.FromSeconds(secondsAll);
            string totalTime = time.ToString(@"hh\:mm\:ss");
            Console.Write("Time Arrival: ");
            Console.WriteLine(totalTime);

        }
    }
}
