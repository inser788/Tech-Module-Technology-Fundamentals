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
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] rotate = new int[number.Length];
            int[] sum = new int[number.Length];

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < number.Length; j++)     // izmestvane na masiva pri vsqka iteraciq
                {
                    rotate[j] = number[j - 1];
                    rotate[0] = number[number.Length - 1];

                }

                for (int k = 0; k < number.Length; k++)    // dobavqne kum sumata pri vsqka iteraciq
                {
                    sum[k] += rotate[k];
                }
                rotate.CopyTo(number, 0);
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
