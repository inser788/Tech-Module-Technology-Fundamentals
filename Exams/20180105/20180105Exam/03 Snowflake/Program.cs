using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternSurface = @"^([^A-Za-z0-9]+)$";
            string patternMantle = @"^([0-9_]+)$";
            string patternCore = @"^([^A-Za-z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)$";


            string input = Console.ReadLine();

            Match matchSurface = Regex.Match(input, patternSurface);
            if (!matchSurface.Success)
            {
                Console.WriteLine("Invalid");
                return;
            }
            input = Console.ReadLine();

            Match matchMantle = Regex.Match(input, patternMantle);

            if (!matchMantle.Success)
            {
                Console.WriteLine("Invalid");
                return;
            }
            input = Console.ReadLine();

            Match matchCore = Regex.Match(input, patternCore);

            if (!matchCore.Success)
            {
                Console.WriteLine("Invalid");
                return;
            }
            int coreLength = matchCore.Groups[3].Value.ToString().Length;
            input = Console.ReadLine();

            if (!matchMantle.Success)
            {
                Console.WriteLine("Invalid");
                return;
            }
            input = Console.ReadLine();

            if (!matchSurface.Success)
            {
                Console.WriteLine("Invalid");
                return;
            }

            Console.WriteLine($"Valid");
            Console.WriteLine(coreLength);



        }
    }
}
