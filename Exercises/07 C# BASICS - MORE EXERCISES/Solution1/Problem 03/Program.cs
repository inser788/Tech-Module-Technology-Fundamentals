﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = width * height;

            double areaMP = area / 1000000.0;

            Console.WriteLine($"{width}x{height} => {Math.Round(areaMP,1)}MP");

        }
    }
}