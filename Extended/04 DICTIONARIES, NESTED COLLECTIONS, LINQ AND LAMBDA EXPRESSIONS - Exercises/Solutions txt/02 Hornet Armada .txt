using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Legion
    {
        public int LastActivity { get; set; }

        public Dictionary<string,long> SoldierTypeAndCount { get; set; }
    }

class Program
{
    static void Main(string[] args)
    {
        int numberOfLines = int.Parse(Console.ReadLine());

        var armies = new Dictionary<string, Legion>();

        for (int i = 0; i < numberOfLines; i++)
        {
            var input = Console.ReadLine()
                .Split("=->: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int lastActivity = int.Parse(input.First());
            string legionName = input.Skip(1).First();
            string soldierType = input.Skip(2).First();
            long soldierCount = long.Parse(input.Last());

            if (!armies.ContainsKey(legionName))
            {
                armies[legionName] = new Legion()
                {
                    LastActivity = lastActivity,
                    SoldierTypeAndCount = new Dictionary<string, long>()
                };
                armies[legionName].SoldierTypeAndCount.Add(soldierType, soldierCount);
                continue;
            }
            if (!armies[legionName].SoldierTypeAndCount.ContainsKey(soldierType))
            {
                armies[legionName].SoldierTypeAndCount[soldierType] = soldierCount;
            }
            else
            {
                armies[legionName].SoldierTypeAndCount[soldierType] += soldierCount;
            }
            if (lastActivity>armies[legionName].LastActivity)
            {
                armies[legionName].LastActivity = lastActivity;
            }
        }
        string[] command = Console.ReadLine()
            .Split("\\".ToCharArray())
            .ToArray();
        if (command.Count()==1)
        {
            var orderedLegion = armies.Where(x=>x.Value.SoldierTypeAndCount.ContainsKey(command[0]))
                .OrderByDescending(x => x.Value.LastActivity)
                .ToDictionary(k=>k.Key,v=>v.Value);
            foreach (var item in orderedLegion)
            {
                Console.WriteLine($"{item.Value.LastActivity} : {item.Key}");
            }
        }
        else
        {
            int activity = int.Parse(command.First());
            string soldier = command.Last();
            var result = new Dictionary<string, long>();
            foreach (var item in armies)
            {
                if (item.Value.LastActivity<activity)
                {
                    foreach (var x in item.Value.SoldierTypeAndCount)
                    {
                        if (x.Key==soldier)
                        {
                            result.Add(item.Key, x.Value);
                        }
                    }
                }
            }
            foreach (var item in result.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            //Console.WriteLine();
        }
    }
}

