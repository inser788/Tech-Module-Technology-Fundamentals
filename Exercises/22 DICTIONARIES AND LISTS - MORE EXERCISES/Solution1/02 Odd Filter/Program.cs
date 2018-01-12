using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(long.Parse).ToList();
            numbers = numbers.Where(num => num % 2 == 0).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]>numbers.Average())
                {
                    numbers[i]++;
                }
                else
                {
                    numbers[i]--;
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
