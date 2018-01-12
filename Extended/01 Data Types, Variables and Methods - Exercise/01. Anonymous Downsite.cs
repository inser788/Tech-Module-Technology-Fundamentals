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
            int N = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            var nameOfAllSites = new List<string>();
            decimal totalPriceLoss = 0m;
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
                string siteName = input.First();
                long siteVisits = long.Parse(input.Skip(1).First());
                decimal pricePerVisit = decimal.Parse(input.Last());
                decimal lossPriceSite = siteVisits * pricePerVisit;
                totalPriceLoss += lossPriceSite;
                nameOfAllSites.Add(siteName);
            }
            Console.WriteLine(string.Join("\n",nameOfAllSites));
            Console.WriteLine($"Total Loss: {totalPriceLoss:f20}");
            BigInteger securityToken = 1;
            for (int i = 0; i < N; i++)
            {
                securityToken *= securityKey;
            }
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
