using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int i = 0;

            while (true)
            {
                var length = listOfNumbers.Count();
                if (length == 1)
                {
                    break;
                }
                if (i==length-1)
                {
                    if (listOfNumbers[i]==listOfNumbers[i-1])
                    {
                        listOfNumbers.RemoveAt(i - 1);
                        i = 0;
                        continue;
                    }
                    else
                    {
                        break;

                    }
                }
                var currentNum = listOfNumbers[i];
                var currentIndex = listOfNumbers.IndexOf(currentNum);
                if (currentIndex == 0)
                {
                    if (currentNum == listOfNumbers[currentIndex + 1])
                    {
                        listOfNumbers.RemoveAt(currentIndex + 1);
                    }
                    else
                    {
                        i++;
                        continue;
                    }
                    continue;
                }
                var sum = listOfNumbers[currentIndex - 1] + listOfNumbers[currentIndex + 1];
                if (currentNum == sum)
                {
                    listOfNumbers.RemoveAt(currentIndex - 1);
                    listOfNumbers.RemoveAt(currentIndex);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
