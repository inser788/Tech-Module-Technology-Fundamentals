using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = numbers.Length / 4;
            var leftSide = numbers.Take(k).Reverse().ToArray();
            var middleSideLeft = numbers.Skip(k).Take(k).ToArray();
            var middleSideRight = numbers.Skip(2 * k).Take(k).ToArray();
            var rightSide = numbers.Skip(3 * k).Take(k).Reverse().ToArray();
            var result = new List<int>();
            for (int i = 0; i < k; i++)
            {
                result.Add(leftSide[i] + middleSideLeft[i]);
            }
            
            for (int i = 0; i < k; i++)
            {
                result.Add(rightSide[i] + middleSideRight[i]);
            }
            
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
