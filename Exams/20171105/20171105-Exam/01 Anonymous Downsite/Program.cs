using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01_Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long secKey = long.Parse(Console.ReadLine());
            decimal totalloss = 0.0m;
            var listOfSites = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ', '\t' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                var siteName = inputLine.First().Trim();
                long siteVisits = long.Parse(inputLine.Skip(1).First());
                decimal priceVisit = decimal.Parse(inputLine.Last());
                totalloss += (siteVisits * priceVisit);
                listOfSites.Add(siteName);
            }
            foreach (var website in listOfSites)
            {
                Console.Write($"{website}");
                Console.WriteLine();
            }
            Console.WriteLine($"Total Loss: {totalloss:f20}");
            BigInteger poweredNum = 1;

            for (int i = 0; i < n; i++)
            {
                poweredNum *= secKey;
            }
            Console.WriteLine($"Security Token: {poweredNum}");
        }
    }
}
