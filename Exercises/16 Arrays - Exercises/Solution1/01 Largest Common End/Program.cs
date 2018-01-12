using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split(' ').ToArray();
            var array2 = Console.ReadLine().Split(' ').ToArray();

            var shorterArray = Math.Min(array1.Length, array2.Length);
            int counterLeft = 0;
            int counterRight = 0;

            for (int i = 0; i < shorterArray; i++)
            {
                if (array1[i]==array2[i])
                {
                    counterLeft++;
                }
            }
            Array.Reverse(array1);
            Array.Reverse(array2);
            for (int i = 0; i < shorterArray; i++)
            {
                if (array1[i] == array2[i])
                {
                    counterRight++;
                }
            }

            var longCommonEnd = Math.Max(counterLeft, counterRight);
            Console.WriteLine(longCommonEnd);

        }
    }
}
