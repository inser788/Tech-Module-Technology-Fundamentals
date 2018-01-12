using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\d+) = ([^\=\-\.\:\s]+) -> ([^\=\-\.\:\s]+):(\d+)$";
            var activityLegion = new Dictionary<string, long>();
            var legionSoldiers = new Dictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var match = Regex.Match(line, pattern);
                var lastActivity = long.Parse(match.Groups[1].Value.ToString().Trim());
                var legionName = match.Groups[2].Value.ToString().Trim();
                var soldierName = match.Groups[3].Value.ToString().Trim();
                var soldiersCount = long.Parse(match.Groups[4].Value.ToString().Trim());

                if (!activityLegion.ContainsKey(legionName))
                {
                    activityLegion[legionName] = 0;
                    activityLegion[legionName] += lastActivity;
                }
                else
                {
                    if (activityLegion[legionName] < lastActivity)
                    {
                        activityLegion[legionName] = lastActivity;
                    }
                }
                if (!legionSoldiers.ContainsKey(legionName))
                {
                    legionSoldiers[legionName] = new Dictionary<string, long>();
                }
                if (!legionSoldiers[legionName].ContainsKey(soldierName))
                {
                    legionSoldiers[legionName][soldierName] = 0;
                    legionSoldiers[legionName][soldierName] += soldiersCount;

                }
                else
                {
                    legionSoldiers[legionName][soldierName] += soldiersCount;
                }
            }

            string newLine = Console.ReadLine();

            string patternFirst = @"^(\d+)\\([^\=\-\.\:\s]+)$";
            string patternSecond = @"^([^\=\-\.\:\s]+)$";

            var matchFirst = Regex.Match(newLine, patternFirst);
            if (matchFirst.Success)
            {
                var activity = long.Parse(matchFirst.Groups[1].Value.ToString().Trim());
                var soldiertype = matchFirst.Groups[2].Value.ToString().Trim();
                var resultActivity = activityLegion.Where(x => x.Value < activity).ToDictionary(k => k.Key, v => v.Value);
                var result = new Dictionary<string, Dictionary<string, long>>();

                foreach (var legion in resultActivity)
                {
                    if (legionSoldiers.Keys.Contains(legion.Key))
                    {
                        result.Add(legion.Key, legionSoldiers[legion.Key]);
                    }
                }
                foreach (var soldier in result.OrderByDescending(x => x.Value.Values.Sum()))
                {
                    foreach (var item in soldier.Value)
                    {
                        if (item.Key == soldiertype)
                        {
                            Console.WriteLine($"{soldier.Key} -> {item.Value}");
                        }
                    }
                }

            }
            var matchSecond = Regex.Match(newLine, patternSecond);
            if (matchSecond.Success)
            {
                var soldiertype = matchSecond.Groups[1].Value.ToString().Trim();
                var resultSoldier = legionSoldiers.Where(x => x.Value.ContainsKey(soldiertype)).ToDictionary(k => k.Key, v => v.Value);
                var result = new Dictionary<string, long>();

                foreach (var item in resultSoldier)
                {
                    if (activityLegion.ContainsKey(item.Key))
                    {
                        result.Add(item.Key, activityLegion[item.Key]);
                    }
                }
                foreach (var item in result.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Value} : {item.Key}");
                }

            }



        }
    }
}
