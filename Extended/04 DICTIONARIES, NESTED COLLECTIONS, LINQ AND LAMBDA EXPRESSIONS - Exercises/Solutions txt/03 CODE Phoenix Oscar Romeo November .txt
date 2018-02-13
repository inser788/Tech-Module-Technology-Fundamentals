using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            var allCreaturesAndTeams = new Dictionary<string, List<string>>();
            var uniqueCreatures = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Blaze it!")
                    break;
                string[] inputLine = input
                    .Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string creature = inputLine.First();
                string squadMate = inputLine.Last();
                if (creature == squadMate)
                    continue;
               
                if (!allCreaturesAndTeams.ContainsKey(creature))
                {
                    allCreaturesAndTeams[creature] = new List<string>();
                    allCreaturesAndTeams[creature].Add(squadMate);
                }
                if (!allCreaturesAndTeams[creature].Contains(squadMate))
                {
                    allCreaturesAndTeams[creature].Add(squadMate);
                }
               
            }
            var result = new Dictionary<string, List<string>>();
            foreach (var item in allCreaturesAndTeams)
            {
                result.Add(item.Key, new List<string>());
                foreach (var squad in item.Value)
                {
                    if (!allCreaturesAndTeams.ContainsKey(squad)&&!allCreaturesAndTeams[squad].Contains(item.Key))
                    {
                        result[item.Key].Add(squad);
                    }
                }
            }
            //Console.WriteLine();
        }
    }
}

