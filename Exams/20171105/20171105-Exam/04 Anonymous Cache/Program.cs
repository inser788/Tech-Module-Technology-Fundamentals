using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var avaibleDataSets = new Dictionary<string, Dictionary<string, long>>();
            var cachedDataSets = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "thetinggoesskrra")
                    break;
                var lineInput = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (lineInput.Length == 1)
                {
                    string dataSet = lineInput.First();
                    if (!avaibleDataSets.ContainsKey(dataSet))
                    {
                        avaibleDataSets[dataSet] = new Dictionary<string, long>();
                    }
                    if (cachedDataSets.ContainsKey(dataSet))
                    {
                        foreach (var match in cachedDataSets[dataSet])
                        {
                            avaibleDataSets[dataSet][match.Key]=match.Value;
                        }
                    }
                    continue;
                }
                else
                {
                    string dataSet = lineInput.Last();
                    string dataKey = lineInput.First();
                    long dataSize = long.Parse(lineInput.Skip(1).First());
                    if (!avaibleDataSets.ContainsKey(dataSet))
                    {
                        if (!cachedDataSets.ContainsKey(dataSet))
                        {
                            cachedDataSets[dataSet] = new Dictionary<string, long>();
                            cachedDataSets[dataSet][dataKey] = dataSize;

                        }
                        else
                        {
                            cachedDataSets[dataSet][dataKey] = dataSize;

                        }
                    }
                    else
                    {
                        if (cachedDataSets.ContainsKey(dataSet))
                        {
                            foreach (var match in cachedDataSets[dataSet])
                            {
                                avaibleDataSets[dataSet][dataKey] = dataSize;
                            }
                        }
                        else
                        {
                            avaibleDataSets[dataSet][dataKey] = dataSize;
                        }
                    }
                }
            }
            if (avaibleDataSets.Count==0)
            {

            }
            else
            {
                var orderedDataSets = avaibleDataSets.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(k => k.Key, v => v.Value);
                foreach (var dataSet in orderedDataSets)
                {
                    Console.WriteLine($"Data Set: {dataSet.Key}, Total Size: {dataSet.Value.Values.Sum()}");
                    foreach (var item in dataSet.Value)
                    {
                        Console.WriteLine($"$.{item.Key}");
                    }
                    return;
                }
            }

        }
    }
}
