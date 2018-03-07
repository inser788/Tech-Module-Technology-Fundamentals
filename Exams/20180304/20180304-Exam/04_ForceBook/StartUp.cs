using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class StartUp
{
    static void Main()
    {
        var forceSidesAndUsers = new Dictionary<string, HashSet<string>>();

        string patternForce = @"(.*?)( \| )(.*)";
        string patternUser = @"(.*?)( \-> )(.*)";


        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Lumpawaroo") break;

            Match matchForce = Regex.Match(input, patternForce);
            if (matchForce.Success)
            {
                string forceSide = matchForce.Groups[1].Value;
                string userSide = matchForce.Groups[3].Value;
                if (!forceSidesAndUsers.ContainsKey(forceSide))
                {
                    forceSidesAndUsers[forceSide]=new HashSet<string>();
                }

                forceSidesAndUsers[forceSide].Add(userSide);

            }

            Match matchUser = Regex.Match(input, patternUser);
            string userSideMatch = matchUser.Groups[1].Value;
            string forceSideMatch = matchUser.Groups[3].Value;
        
        }
    }
}

