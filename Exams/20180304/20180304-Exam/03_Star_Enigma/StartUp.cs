using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class StartUp
{
    static void Main()
    {
        string pattern =
            @"\@(?<name>[a-zA-Z]+)[^\@\-\!\:\>]*:[\d]+[^\@\-\!\:\>]*\!(?<typeAttack>[A|D])\![^\@\-\!\:\>]*\->[\d]+";

        var attackedPlanets = new List<string>();
        var destroyedPlanets = new List<string>();

        int numberOfLines = int.Parse(Console.ReadLine());
        while (numberOfLines-- != 0)
        {
            string input = Console.ReadLine();
            string result = GetDecryptedMessage(input);

            Match match = Regex.Match(result, pattern);
            if (!match.Success)
                continue;
            AddAttackInformation(match, attackedPlanets, destroyedPlanets);
        }
        PrintResult(attackedPlanets, destroyedPlanets);
    }

    private static void PrintResult(List<string> attackedPlanets, List<string> destroyedPlanets)
    {
        Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
        if (attackedPlanets.Count != 0)
            attackedPlanets.ForEach(p => Console.WriteLine($"-> {p}"));
        Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
        if (destroyedPlanets.Count != 0)
            destroyedPlanets.ForEach(p => Console.WriteLine($"-> {p}"));
    }

    private static void AddAttackInformation(Match match, List<string> attackedPlanets, List<string> destroyedPlanets)
    {
        string planetName = match.Groups["name"].ToString();
        string searchedSymbol = match.Groups["typeAttack"].ToString();
        if (searchedSymbol == "A")
        {
            attackedPlanets.Add(planetName);
            attackedPlanets.Sort();
        }
        else
        {
            destroyedPlanets.Add(planetName);
            destroyedPlanets.Sort();
        }
    }

    private static string GetDecryptedMessage(string input)
    {
        string result = string.Empty;
        int counter = 0;
        foreach (var letter in input.ToLower())
        {
            if (letter == 's' || letter == 't' || letter == 'a' || letter == 'r')
            {
                counter++;
            }
        }

        return result = new string(input.Select(c => (char) (c - counter)).ToArray());
    }
}

