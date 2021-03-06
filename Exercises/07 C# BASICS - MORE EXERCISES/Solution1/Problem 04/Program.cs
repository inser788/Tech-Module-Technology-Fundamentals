﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int name = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double bytes = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string bytesNew = bytes.ToString();
            string orientation = " ";


            if (bytes <= 999)
            {
                bytesNew = bytes.ToString() + "B";
                
            }
            else if (bytes >= 1000 && bytes <= 999999)
            {
                Math.Round(bytes /= 1000,1);
                bytesNew = bytes.ToString() + "KB";

            }
            else
            {
                Math.Round(bytes /= 1000000,1);


                bytesNew = bytes.ToString() + "MB";
            }
            if (width>height)
            {
                orientation = "(landscape)";
            }
            else if (width < height)
            {
                orientation = "(portrait)";

            }
            else
            {
                orientation = "(square)";

            }
            Console.WriteLine($"Name: DSC_{name:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            Console.WriteLine($"Size: {bytesNew}");
            Console.WriteLine($"Resolution: {width}x{height} {orientation}");
        }
    }
}
