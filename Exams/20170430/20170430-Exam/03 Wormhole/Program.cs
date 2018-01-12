using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int i = 0;
            int steps = 0;
            
            while (true)
            {
                int currentIndex = i;
                if (currentIndex > arrayNumbers.Length-1)
                    break;
                int currentnumber = arrayNumbers[i];
                if (currentnumber == 0)
                {
                    currentIndex++;
                    steps++;
                    i++;
                }
                else
                {
                    currentIndex = currentnumber;
                    arrayNumbers[i]-=currentIndex;
                    i = currentIndex;
                }
            }
            Console.WriteLine(steps);
        }
    }
}
