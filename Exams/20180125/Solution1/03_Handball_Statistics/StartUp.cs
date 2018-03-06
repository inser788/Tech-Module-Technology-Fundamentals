using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    class Country
    {
        public string Name { get; set; }
        public int GoalsHome { get; set; }
        public int GoalsAway { get; set; }
        public int TotalGoals { get; set; }
        public int Wins { get; set; }
        public List<string> Opponents { get; set; }

    }

    static void Main()
    {
        var listOfTeams = new Dictionary<string, Country>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "stop")
                break;
            string[] dataTeams = input.Split(new[] {" | "}, StringSplitOptions.RemoveEmptyEntries);

            listOfTeams = GetTeamsList(listOfTeams, dataTeams);

        }

        listOfTeams = listOfTeams.OrderByDescending(x => x.Value.Wins).ThenBy(x => x.Value.Name)
            .ToDictionary(k => k.Key, v => v.Value);
        foreach (var team in listOfTeams.Values)
        {
            Console.WriteLine(team.Name);
            Console.WriteLine($"- Wins: {team.Wins}");
            Console.WriteLine($"- Opponents: " + string.Join(", ", team.Opponents));
        }
    }

    static Dictionary<string, Country> GetTeamsList(Dictionary<string, Country> listOfTeams,
        string[] dataTeams)
    {
        string firstTeam = dataTeams[0].Trim();
        string secondTeam = dataTeams[1].Trim();
        string firstVsSecondResult = dataTeams[2].Trim();
        string secondVsFirstResult = dataTeams[3].Trim();
        listOfTeams = GetTeamData(listOfTeams, firstTeam, firstVsSecondResult, secondVsFirstResult, secondTeam);
        listOfTeams = GetTeamData(listOfTeams, secondTeam, secondVsFirstResult, firstVsSecondResult, firstTeam);
        if (listOfTeams[firstTeam].TotalGoals > listOfTeams[secondTeam].TotalGoals)
        {
            listOfTeams[firstTeam].Wins++;
        }
        else if (listOfTeams[secondTeam].TotalGoals > listOfTeams[firstTeam].TotalGoals)
        {
            listOfTeams[secondTeam].Wins++;
        }
        else
        {
            if (listOfTeams[firstTeam].GoalsAway > listOfTeams[secondTeam].GoalsAway)
            {
                listOfTeams[firstTeam].Wins++;
            }
            else if (listOfTeams[secondTeam].GoalsAway > listOfTeams[firstTeam].GoalsAway)
            {
                listOfTeams[secondTeam].Wins++;
            }
        }

        return listOfTeams;
    }

    static Dictionary<string, Country> GetTeamData(Dictionary<string, Country> listTeams, string teamName,
        string firstResult,
        string secondResult, string opponent)
    {
        if (!listTeams.ContainsKey(teamName))
        {
            listTeams[teamName] = new Country();
            listTeams[teamName].Opponents = new List<string>();
        }

        listTeams[teamName].Name = teamName;
        listTeams[teamName].GoalsHome = int.Parse(firstResult.Split(":".ToCharArray()).First());
        listTeams[teamName].GoalsAway = int.Parse(secondResult.Split(":".ToCharArray()).Last());
        listTeams[teamName].TotalGoals = 0;
        listTeams[teamName].TotalGoals += listTeams[teamName].GoalsHome + listTeams[teamName].GoalsAway;

        listTeams[teamName].Opponents.Add(opponent);
        listTeams[teamName].Opponents.Sort();


        return listTeams;
    }
}

