using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthOfTriangle = double.Parse(Console.ReadLine());
            double heightOfTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfTriangle(widthOfTriangle,heightOfTriangle));

        }
        static double AreaOfTriangle(double widthOfTriangle, double heightOfTriangle)
        {
            return (widthOfTriangle * heightOfTriangle) / 2;
        }
    }
}
