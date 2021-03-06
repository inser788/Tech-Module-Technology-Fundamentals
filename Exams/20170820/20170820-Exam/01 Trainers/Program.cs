﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPartisipants = int.Parse(Console.ReadLine());
            var listMoney = new Dictionary<string, decimal>
            {
                { "Technical",0.0m },
                { "Theoretical",0.0m},
                { "Practical", 0.0m}
            };
            for (int i = 0; i < numberOfPartisipants; i++)
            {
                long distanceInMiles = long.Parse(Console.ReadLine()) * 1600;
                decimal cargoinTons = decimal.Parse(Console.ReadLine()) * 1000;
                string teamName = Console.ReadLine().Trim();
                listMoney[teamName] += (cargoinTons * 1.5m) - (0.7m * distanceInMiles * 2.5m);
            }
            foreach (var team in listMoney.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"The {team.Key} Trainers win with ${team.Value:f3}.");
                return;
            }
        }
    }
}
