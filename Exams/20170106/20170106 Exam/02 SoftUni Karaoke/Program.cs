using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfTopMusicants = new Dictionary<string, SortedDictionary<string, int>>();
            var separators = new string[] { ", " };
            var musicantsNames = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var songsNames = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "dawn")
            {
                var currentInput = input.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
                string musicant = currentInput[0].Trim();
                string song = currentInput[1].Trim();
                string award = currentInput[2].Trim();
                int numberOfAwards = 1;
                if (!listOfTopMusicants.ContainsKey(musicant)
                    && musicantsNames.Contains(musicant)
                    && songsNames.Contains(song))
                {
                    listOfTopMusicants[musicant] = new SortedDictionary<string, int>();
                    if (!listOfTopMusicants[musicant].ContainsKey(award)
                        && musicantsNames.Contains(musicant)
                        && songsNames.Contains(song))
                    {
                        listOfTopMusicants[musicant][award] = numberOfAwards;
                    }
                }
                else if (listOfTopMusicants.ContainsKey(musicant)
                    && musicantsNames.Contains(musicant)
                    && songsNames.Contains(song)
                    && !listOfTopMusicants[musicant].ContainsKey(award))
                {
                    listOfTopMusicants[musicant][award] = numberOfAwards;
                }

                input = Console.ReadLine();


            }
            if (listOfTopMusicants.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                var orderedPersons = listOfTopMusicants.OrderByDescending(x => x.Value.Values.Sum());
                foreach (var person in orderedPersons)
                {
                    Console.WriteLine($"{person.Key}: {person.Value.Values.Sum()} awards");
                    foreach (var awa in person.Value.Keys)
                    {
                        Console.WriteLine($"--{awa}");
                    }
                }
            }
        }
    }
}
