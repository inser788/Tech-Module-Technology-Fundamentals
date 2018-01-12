using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {


            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var pos = 0;
            var length = 1;
            var bestPos = 0;
            var bestLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    pos = numbers[i - 1];
                    length++;
                }
                else
                {
                    pos = 0;
                    length = 1;
                }
                if (length > bestLength)
                {
                    bestLength = length;
                    bestPos = pos;
                }


            }
            if (bestPos == 0 && bestLength == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {


                var result = new List<int>();
                for (int i = 0; i < bestLength; i++)
                {
                    result.Add(bestPos);
                }
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
