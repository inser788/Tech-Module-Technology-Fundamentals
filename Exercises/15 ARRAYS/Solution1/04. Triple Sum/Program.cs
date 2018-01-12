using System;
using System.Linq;

namespace P04_TripleSum
{
    class P04_TripleSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

            bool isThereASum = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sum = array[i] + array[j];
                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {sum}");
                        isThereASum = true;
                    }
                }
            }

            if (!isThereASum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
