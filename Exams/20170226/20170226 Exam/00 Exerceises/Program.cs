using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Legion
{
    public long Activity { get; set; }

    public Dictionary<string, long> LegionArmy { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        //string pattern = @"^(\d+) = ([^\=\-\.\:\s]+) -> ([^\=\-\.\:\s]+):(\d+)$";
        var legionSoldiers = new Dictionary<string, Legion>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(new char[] { ' ', ':', '=', '.', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var lastActivity = long.Parse(line[0].Trim());
            var legionName = line[1].Trim();
            var soldierName = line[2].Trim();
            var soldiersCount = long.Parse(line[3].Trim());

            Legion legionCurrent = new Legion();
            legionCurrent.Activity = lastActivity;
            legionCurrent.LegionArmy = new Dictionary<string, long>();
            legionCurrent.LegionArmy.Add(soldierName, 0);

            if (!legionSoldiers.ContainsKey(legionName))
            {
                legionSoldiers[legionName] = legionCurrent;
            }
            if (legionSoldiers[legionName].LegionArmy.ContainsKey(soldierName))
            {
                legionSoldiers[legionName].LegionArmy[soldierName] += soldiersCount;
            }
            else
            {
                legionSoldiers[legionName].LegionArmy.Add(soldierName, soldiersCount);
            }
            if (legionSoldiers[legionName].Activity<lastActivity)
            {
                legionSoldiers[legionName].Activity = lastActivity;
            }
        }

        var newLine = Console.ReadLine().Split(new char[]{ '\\'},StringSplitOptions.None).ToArray();
        if (newLine.Length>1)
        {
            long activity = long.Parse(newLine.First());
            string soldier = newLine.Last();

            var result = legionSoldiers.Where(x => x.Value.Activity < activity)
                                       .ToDictionary(k => k.Key, v => v.Value);

            foreach (var legion in result.OrderByDescending(x=>x.Value.LegionArmy[soldier]))
            {
                foreach (var soldierType in legion.Value.LegionArmy)
                {
                    if (soldierType.Key==soldier)
                    {
                        Console.WriteLine($"{legion.Key} -> {soldierType.Value}");
                    }
                }
            }
        }
        else
        {
            string soldier = newLine.First();
            var result=legionSoldiers.Where(x=>x.Value.LegionArmy.ContainsKey(soldier))
                                       .ToDictionary(k => k.Key, v => v.Value);

            foreach (var soldierType in result.OrderByDescending(x=>x.Value.Activity))
            {
                Console.WriteLine($"{soldierType.Value.Activity} : {soldierType.Key}");
            }

        }




    }
}

