using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool foundedIndex = false;
            for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
            {
                var leftSum = 0;
                var rightSum = 0;
                for (int i = 0; i < currentElement; i++)
                {
                    leftSum += numbers[i];
                }
                for (int i = currentElement+1; i < numbers.Length; i++)
                {
                    rightSum += numbers[i];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(currentElement);
                    foundedIndex = true;
                    break;
                }
            }
            if (!foundedIndex)
            {
                Console.WriteLine("no");
            }
               
            

        }
    }
}
