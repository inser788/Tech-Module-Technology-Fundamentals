using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long specialNumber = long.Parse(Console.ReadLine());
            if (!numbers.Contains(specialNumber))
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                var arraySum = numbers.Sum();
                Array.Reverse(numbers);
                long sumToSpecialNumber = 0l;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i]==specialNumber)
                    {
                        break;
                    }
                    else
                    {
                        sumToSpecialNumber += numbers[i];
                    }
                }
                long newSum = arraySum - sumToSpecialNumber-specialNumber;
                Console.WriteLine(newSum);
                
            }
        }

    }
}
