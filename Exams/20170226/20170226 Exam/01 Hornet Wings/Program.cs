﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            double wingFlaps = double.Parse(Console.ReadLine());
            double distanceFor1000WingFlaps = double.Parse(Console.ReadLine());
            double restTime = double.Parse(Console.ReadLine());
            double distanceInMeters = (wingFlaps / 1000.0) * distanceFor1000WingFlaps;
            long hornetFlapsInSeconds = (int)(wingFlaps / 100);
            long secondsForRest = (((int)wingFlaps / (int)restTime) * 5);
            long secondsAll = hornetFlapsInSeconds + secondsForRest;
            Console.WriteLine($"{distanceInMeters:f2} m.");
            Console.WriteLine($"{secondsAll} s.");
            
        }
    }
}
