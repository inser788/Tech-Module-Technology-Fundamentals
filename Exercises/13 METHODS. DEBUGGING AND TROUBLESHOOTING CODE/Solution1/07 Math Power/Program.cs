using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = GetPowerOfNumber(number, power);
            Console.WriteLine(result);


        }
        static double GetPowerOfNumber(double number,double power)
        {
            return Math.Pow(number, power);
        }
    }
}
