using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfSpies = new Dictionary<string, Dictionary<string, long>>();
            string pattern = " -> ";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "quit")
                    break;

                var split = Regex.Split(input, pattern).ToList();
                var countryName = split.First();
                var spyName = split.Skip(1).First();
                var days = long.Parse(split.Last());

                if (!listOfSpies.ContainsKey(countryName))
                {
                    listOfSpies[countryName] = new Dictionary<string, long>();
                }
                if (!listOfSpies[countryName].ContainsKey(spyName))
                {
                    listOfSpies[countryName][spyName] = days;
                }
                else
                {
                    listOfSpies[countryName][spyName] = days;
                }
            }
            foreach (var country in listOfSpies.OrderByDescending(x=>x.Value.Keys.Count()))
            {
                Console.WriteLine($"Country: {country.Key}");
                foreach (var spy in country.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
