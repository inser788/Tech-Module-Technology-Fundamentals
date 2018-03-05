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
        public int Wins { get; set; }
        public List<string> Opponents { get; set; }
        
     }

    static void Main()
    {
        var listOfTeams = new SortedDictionary<string, Country>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "stop")
                break;
            string[] dataTeams = input.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            listOfTeams = GetTeamsList(listOfTeams, dataTeams);
        }
    }

    static SortedDictionary<string, Country> GetTeamsList(SortedDictionary<string, Country> listOfTeams,
        string[] dataTeams)
    {
        string firstTeam = dataTeams[0].Trim();
        string secondTeam = dataTeams[1].Trim();
        string firstVsSecondResult = dataTeams[2].Trim();
        string secondVsFirstResult = dataTeams[3].Trim();
        listOfTeams = GetTeamData(listOfTeams, firstTeam, firstVsSecondResult, secondVsFirstResult, secondTeam);
        listOfTeams = GetTeamData(listOfTeams, secondTeam, secondVsFirstResult, firstVsSecondResult, firstTeam);


        return listOfTeams;
    }

    static SortedDictionary<string, Country> GetTeamData(SortedDictionary<string, Country> listTeams, string teamName, string firstResult,
        string secondResult, string opponent)
    {
        if (!listTeams.ContainsKey(teamName))
        {
            listTeams[teamName] = new Country();
            listTeams[teamName].Name = teamName;
            listTeams[teamName].Opponents = new List<string>();
        }

        listTeams[teamName].GoalsHome = int.Parse(firstResult.Split(":".ToCharArray()).First());
        listTeams[teamName].GoalsAway = int.Parse(secondResult.Split(":".ToCharArray()).Last());
        if (!listTeams[teamName].Opponents.Contains(opponent))
        {
            listTeams[teamName].Opponents.Add(opponent);
        }

        return listTeams;
    }
}

