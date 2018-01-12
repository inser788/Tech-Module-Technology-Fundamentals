using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var forecastCities = new Dictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(?<cityName>[A-Z][A-Z])(?<averageTemp>\d+.\d+)(?<weather>[A-Za-z]+)\|");
            while (input != "end")
            {
                var cityName = pattern.Match(input).Groups["cityName"].ToString();
                var averageTemp = pattern.Match(input).Groups["averageTemp"].ToString();
                var weather = pattern.Match(input).Groups["weather"].ToString();
                if (cityName.Any() || averageTemp.Any() || weather.Any())
                {
                    if (!forecastCities.ContainsKey(cityName))
                    {
                        forecastCities[cityName] = new Dictionary<string, double>();
                        forecastCities[cityName][weather] = double.Parse(averageTemp);
                    }
                    else
                    {
                        forecastCities[cityName].Clear();
                        forecastCities[cityName][weather] = double.Parse(averageTemp);
                    }
                    input = Console.ReadLine();
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
            }
             forecastCities = forecastCities.OrderBy(a => a.Value.Values.Sum()).ToDictionary(k =>k.Key,v =>v.Value);
            foreach (var item in forecastCities)
            {
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"{item.Key} => {kvp.Value} => {kvp.Key}");
                }
            }
            
        }
    }
}
