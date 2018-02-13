using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var realDataBases = new Dictionary<string, Dictionary<string, long>>();
            var cachedDataBases = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "thetinggoesskrra")
                    break;
                var lineOfElements = input.Split(" ->|".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (lineOfElements.Count() == 1)
                {
                    if (!realDataBases.ContainsKey(lineOfElements[0]))
                        realDataBases[lineOfElements[0]] = new Dictionary<string, long>();
                    continue;
                }
                string dataKey = lineOfElements.First();
                long dataSize = long.Parse(lineOfElements.Skip(1).First());
                string dataSet = lineOfElements.Last();
                if (!realDataBases.ContainsKey(dataSet))
                {
                    if (!cachedDataBases.ContainsKey(dataSet))
                    {
                        cachedDataBases[dataSet] = new Dictionary<string, long>();
                        if (!cachedDataBases[dataSet].ContainsKey(dataKey))
                        {
                            cachedDataBases[dataSet][dataKey] = dataSize;
                        }
                        else
                        {
                            cachedDataBases[dataSet][dataKey] += dataSize;
                        }
                        continue;
                    }
                    if (!cachedDataBases[dataSet].ContainsKey(dataKey))
                    {
                        cachedDataBases[dataSet][dataKey] = dataSize;
                    }
                    else
                    {
                        cachedDataBases[dataSet][dataKey] += dataSize;
                    }
                    continue;
                }
                if (!realDataBases[dataSet].ContainsKey(dataKey))
                {
                    realDataBases[dataSet][dataKey] = dataSize;
                }
                else
                {
                    realDataBases[dataSet][dataKey] += dataSize;
                }

            }
            foreach (var item in cachedDataBases)
            {
                if (realDataBases.ContainsKey(item.Key))
                {
                    foreach (var key in item.Value)
                    {
                        if (!realDataBases[item.Key].ContainsKey(key.Key))
                        {
                            realDataBases[item.Key][key.Key] = key.Value;
                        }
                        else
                        {
                            realDataBases[item.Key][key.Key] += key.Value;
                        }
                    }
                }
            }
            var orderedDatabase = realDataBases.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(k => k.Key, v => v.Value);
            foreach (var item in orderedDatabase)
            {
                Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");
                foreach (var x in item.Value)
                {
                    Console.WriteLine($"$.{x.Key}");
                }
                return;
            }
           // Console.WriteLine();

        }
    }
}
