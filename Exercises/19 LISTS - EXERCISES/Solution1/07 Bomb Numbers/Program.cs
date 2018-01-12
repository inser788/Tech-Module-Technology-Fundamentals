using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersSequance = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var placeOfBomb = bombNumbers[0];
            var rangeOfBomb = bombNumbers[1];

            for (int i = 0; i < numbersSequance.Count; i++)
            {
                var currentNum = numbersSequance[i];
                if (currentNum==placeOfBomb)
                {
                    var indexOfBomb = numbersSequance.IndexOf(currentNum);
                    var rightRangeOfBomb = Math.Min(indexOfBomb + rangeOfBomb,numbersSequance.Count-1);
                    var leftRangeOfBomb = Math.Max(indexOfBomb - rangeOfBomb, 0);
                    var deletedElements = rightRangeOfBomb - leftRangeOfBomb + 1;
                    numbersSequance.RemoveRange(leftRangeOfBomb, deletedElements);
                    i = -1;
                }
            }
            Console.WriteLine(numbersSequance.Sum());


        }
    }
}
