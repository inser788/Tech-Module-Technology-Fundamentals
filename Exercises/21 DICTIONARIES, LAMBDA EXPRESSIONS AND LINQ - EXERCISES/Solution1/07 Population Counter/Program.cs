using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim();
            var dataOfpopulation = new Dictionary<string, Dictionary<string, long>>();
            while (input != "report")
            {
                var dataInput = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var countryName = dataInput[1];
                var cityName = dataInput[0];
                var cityPopulation = long.Parse(dataInput[2]);
                if (!dataOfpopulation.ContainsKey(countryName))
                {
                    dataOfpopulation[countryName] = new Dictionary<string, long>();
                }
                if (!dataOfpopulation[countryName].ContainsKey(cityName))
                {
                    dataOfpopulation[countryName][cityName] = cityPopulation;
                }
                input = Console.ReadLine().Trim();

            }
            var orderedDataPopulation = dataOfpopulation.OrderByDescending(x => x.Value.Values.Sum());
            foreach (var country in orderedDataPopulation)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                var orderedCityes = country.Value.OrderByDescending(x => x.Value);
                foreach (var city in orderedCityes)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
