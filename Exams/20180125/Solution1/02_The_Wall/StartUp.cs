using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var listOfItems = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(x => x < 30)
            .ToList();

        var resultList = new List<long>();
        for (int i = 0; i <= listOfItems.Count; i++)
        {
            listOfItems = listOfItems.Select(x => x + 1).ToList();
            int counter = listOfItems.Where(x => x <= 30).ToList().Count();
            resultList.Add(counter * 195);

            listOfItems = listOfItems.Where(x => x < 30).ToList();
            i = 0;
            if (listOfItems.Count == 0)
                break;
        }

        Console.WriteLine(string.Join(", ",resultList));
        Console.WriteLine($"{resultList.Sum()*1900} coins");
    }
}

