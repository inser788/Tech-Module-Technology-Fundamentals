using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var currentSum = 0;
            var result = new List<int>();
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i-1]==numbers[i])
                {
                    result.Add(2 * numbers[i-1]);
                }
                else
                {
                    result.Add(numbers[i-1]);
                }
                Console.WriteLine(string.Join(" ",result));
            }
        }
    }
}
