﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            var creaturesAndSquad = new Dictionary<string, List<string>>();
            var result = new Dictionary<string, List<string>>();
            while (true)
            {
                string lineInput = Console.ReadLine();
                if (lineInput == "Blaze it!")
                    break;
                var line = lineInput.Split(new string[] { " -> " }, StringSplitOptions.None);
                var creatureName = line.First().ToString();
                var squadName = line.Last().ToString();
                if (creatureName == squadName)
                    continue;
                if (!creaturesAndSquad.ContainsKey(creatureName))
                {
                    creaturesAndSquad[creatureName] = new List<string>();
                }
                if (!creaturesAndSquad[creatureName].Contains(squadName))
                {
                    creaturesAndSquad[creatureName].Add(squadName);
                }
                else
                {
                    continue;
                }
                

            }
            foreach (var item in creaturesAndSquad)
            {
                result.Add(item.Key, new List<string>());
                foreach (var squad in item.Value)
                {
                    if (creaturesAndSquad.ContainsKey(squad)&&creaturesAndSquad[squad].Contains(item.Key))
                    {
                        continue;
                    }
                    else
                    {
                        result[item.Key].Add(squad);
                    }
                }
            }

            foreach (var item in result.OrderByDescending(x=>x.Value.Count()))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }

        }
    }
}