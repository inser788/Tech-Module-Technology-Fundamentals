using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _00_test
{
    class StartUp
    {
        static void Main()
        {
            var forceSidesAndUsers = new SortedDictionary<string, SortedSet<string>>();
            var checkedList = new HashSet<string>();

            string patternForce = @"(.*?)( \| )(.*)";
            string patternUser = @"(.*?)( \-> )(.*)";


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo") break;

                Match matchForce = Regex.Match(input, patternForce);
                if (matchForce.Success)
                {
                    string forceSideName = matchForce.Groups[1].Value.Trim();
                    string userSideName = matchForce.Groups[3].Value.Trim();
                    if (!forceSidesAndUsers.ContainsKey(forceSideName))
                    {
                        forceSidesAndUsers[forceSideName] = new SortedSet<string>();
                    }

                    if (checkedList.Contains(userSideName))
                    {
                        continue;
                    }

                    forceSidesAndUsers[forceSideName].Add(userSideName);
                    checkedList.Add(userSideName);
                    continue;
                }

                Match matchUser = Regex.Match(input, patternUser);
                string userSideMatchName = matchUser.Groups[1].Value.Trim();
                string forceSideMatchName = matchUser.Groups[3].Value.Trim();
                string changedForse = string.Empty;
                if (!forceSidesAndUsers.ContainsKey(forceSideMatchName))
                {
                    forceSidesAndUsers[forceSideMatchName] = new SortedSet<string>();
                    if (!checkedList.Contains(userSideMatchName))
                    {
                        forceSidesAndUsers[forceSideMatchName].Add(userSideMatchName);
                        checkedList.Add(userSideMatchName);
                        Console.WriteLine($"{userSideMatchName} joins the {forceSideMatchName} side!");
                        continue;
                    }
                }


                foreach (var side in forceSidesAndUsers)
                {
                    if (side.Value.Contains(userSideMatchName))
                    {
                        changedForse = side.Key;
                        break;
                    }
                }

                if (changedForse != String.Empty)
                {
                    forceSidesAndUsers[changedForse].Remove(userSideMatchName);
                }

                forceSidesAndUsers[forceSideMatchName].Add(userSideMatchName);
                Console.WriteLine($"{userSideMatchName} joins the {forceSideMatchName} side!");
            }

            var result = forceSidesAndUsers.OrderByDescending(x => x.Value.Count);
            foreach (var side in result)
            {
                if (side.Value.Count == 0)
                    break;
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
