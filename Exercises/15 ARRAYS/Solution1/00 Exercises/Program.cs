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
            var array1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var array2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var n = Math.Max(array1.Length, array2.Length);
            var sumArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                var a = array1[i % array1.Length];
                var b = array2[i % array2.Length];
                sumArray[i] = a + b;
            }
            Console.WriteLine(string.Join(" ",sumArray));
        }
    }
}
