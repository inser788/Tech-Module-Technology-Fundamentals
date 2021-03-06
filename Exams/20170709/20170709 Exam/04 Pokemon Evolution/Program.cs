﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Evolution
{
    public string EvolutionType { get; set; }

    public long IndexEvolution { get; set; }

}


class Program
{
    static void Main(string[] args)
    {
        var pokemonsList = new Dictionary<string, List<Evolution>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "wubbalubbadubdub")
                break;
            var currentLine = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (currentLine.Length > 1)
            {
                var pokemonName = currentLine.First();
                var pokemonEvolution = currentLine.Skip(1).First();
                var indexEvolution = long.Parse(currentLine.Last());

                Evolution currentEvolution = new Evolution();
                currentEvolution.EvolutionType = pokemonEvolution;
                currentEvolution.IndexEvolution = indexEvolution;
                if (!pokemonsList.ContainsKey(pokemonName))
                {
                    pokemonsList[pokemonName] = new List<Evolution>();
                }
                pokemonsList[pokemonName].Add(currentEvolution);

            }
            else
            {
                var pokemonForPrint = currentLine.First();
                if (!pokemonsList.ContainsKey(pokemonForPrint))
                    continue;

                foreach (var pokemon in pokemonsList)
                {
                    if (pokemon.Key == pokemonForPrint)
                    {
                        Console.WriteLine($"# {pokemon.Key}");
                        foreach (var item in pokemon.Value)
                        {
                            Console.WriteLine($"{item.EvolutionType} <-> {item.IndexEvolution}");
                        }
                    }
                }
            }
        }

        foreach (var pokemon in pokemonsList)
        {
            Console.WriteLine($"# {pokemon.Key}");
            foreach (var item in pokemon.Value.OrderByDescending(x=>x.IndexEvolution))
            {
                Console.WriteLine($"{item.EvolutionType} <-> {item.IndexEvolution}");
            }
        }

    }
}

