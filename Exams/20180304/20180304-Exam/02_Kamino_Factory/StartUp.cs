using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        int lengthSequance = int.Parse(Console.ReadLine());
        var listOfAllSequances = new List<string>();
        var listOfBestPosition = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Clone them!") break;
            var allDigits = new string(input.Where(n => char.IsDigit(n)).ToArray());

            int longestSeqLength = 1;
            int longestSeqStart = 0;
            int currentSeqLength = 1;
            int currentSeqStart = 0;

            for (int i = 1; i < allDigits.Length; i++)
            {
                if (allDigits[i] == allDigits[i - 1] && allDigits[i] == '1')
                {
                    currentSeqLength++;

                    if (currentSeqLength > longestSeqLength)
                    {
                        longestSeqLength = currentSeqLength;
                        longestSeqStart = currentSeqStart;
                    }
                }
                else
                {
                    currentSeqLength = 1;
                    currentSeqStart = i;
                }
            }

            listOfAllSequances.Add(allDigits);
            listOfBestPosition.Add(longestSeqStart);

        }

        var tempResult = new List<int>();
        int minIndex = listOfBestPosition.Min();
        int startPos = 0;
        int startSum = 0;
        int counter = -1;
        for (int i = 0; i < listOfBestPosition.Count; i++)
        {
            if (listOfBestPosition[i] == minIndex)
            {
                tempResult.Add(i);
                counter++;
                if (listOfAllSequances.ElementAt(tempResult[counter]).Sum(x => int.Parse(x.ToString())) > startSum)
                {
                    startSum = listOfAllSequances.ElementAt(tempResult[counter]).Sum(x => int.Parse(x.ToString()));
                    startPos = i;
                }
            }
        }

        if (tempResult.Count == 1)
        {
            Console.WriteLine($"Best DNA sample {startPos + 1} with sum: {startSum}.");
            Console.WriteLine(string.Join(" ", listOfAllSequances.ElementAt(startPos).ToArray()));
        }
        else
        {
            Console.WriteLine($"Best DNA sample {startPos + 1} with sum: {startSum}.");
            Console.WriteLine(string.Join(" ", listOfAllSequances.ElementAt(startPos).ToArray()));
        }
    }
}

