using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_WorkOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTraining = int.Parse(Console.ReadLine());
            double firstDayKilometers = double.Parse(Console.ReadLine());
            double totalSum = firstDayKilometers;
            for (int i = 0; i < daysOfTraining; i++)
            {
                double percentMore = double.Parse(Console.ReadLine()) / 100.0;
                firstDayKilometers *=(1+ percentMore);
                totalSum += firstDayKilometers;
            }
            if (totalSum>=1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalSum-1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000-totalSum)} more kilometers");
            }
        }
    }
}
