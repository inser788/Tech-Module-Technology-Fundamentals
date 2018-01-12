using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            int[] roundedNums = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {roundedNums[i]}");
            }
        }
    }
}

