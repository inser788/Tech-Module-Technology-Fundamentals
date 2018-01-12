using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var wormTeamsSuccess = new Dictionary<string, Dictionary<string, long>>();
            var listOfWorms = new List<string>();
            var pattern = @"^(?<wormName>[a-zA-Z0-9\s]+)->(?<teamName>[a-zA-Z0-9\s]+)->(?<wormScore>[a-zA-Z0-9\s]+)$";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "quit")
                    break;
                var match = Regex.Match(input, pattern);
                if (!match.Success)
                    continue;
                var wormName = match.Groups[1].Value.Trim();
                var teamName = match.Groups[2].Value.Trim();
                var wormScore = long.Parse(match.Groups[3].Value.Trim());
                if (!listOfWorms.Contains(wormName))
                {
                    listOfWorms.Add(wormName);
                    if (!wormTeamsSuccess.ContainsKey(teamName))
                    {
                        wormTeamsSuccess[teamName] = new Dictionary<string, long>();
                    }
                    if (!wormTeamsSuccess[teamName].ContainsKey(wormName))
                    {
                        wormTeamsSuccess[teamName][wormName] = wormScore;
                    }
                }
                else
                {
                    continue;
                }
            }
            //The teams must be ordered by total score of their worms,
            //in descending order, and if 2 teams have the same total score,
            //they must be ordered by average score (totalScore / wormCount) in descending order.
            //For each team you must print its worms, ordered by descending order of their score.
            var orderedTeams = wormTeamsSuccess.OrderByDescending(ts => ts.Value.Values.Sum())
                                             .ThenBy(av => av.Value.Keys.Count())
                                             .ToDictionary(k => k.Key, v => v.Value);
            int i = 0;


            foreach (var team in orderedTeams)
            {
                ++i;
                Console.WriteLine($"{i}. Team: {team.Key} - {team.Value.Values.Sum()}");
                foreach (var member in team.Value.OrderByDescending(a=>a.Value))
                {
                    Console.WriteLine($"###{member.Key} : {member.Value}");
                }
            }


        }
    }
}
