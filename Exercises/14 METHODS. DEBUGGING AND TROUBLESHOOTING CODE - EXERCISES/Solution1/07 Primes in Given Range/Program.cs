using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong startNumber = ulong.Parse(Console.ReadLine());
            ulong endNumber = ulong.Parse(Console.ReadLine());


            var primes = FindPrimesInRange(startNumber,endNumber);
            Console.WriteLine(string.Join(", ",primes));
        }

        private static List<ulong> FindPrimesInRange(ulong startNumber, ulong endNumber)
        {
            var primes = new List<ulong>();

            for (ulong currentNum = startNumber; currentNum <= endNumber; currentNum++)
            {
                if (IsPrimeNumber(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
        }
        static bool IsPrimeNumber(ulong number)
        {
            if (number == 0)
            {
                return false;

            }
            else if (number == 1)
            {
                return false;
            }
            for (ulong i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
