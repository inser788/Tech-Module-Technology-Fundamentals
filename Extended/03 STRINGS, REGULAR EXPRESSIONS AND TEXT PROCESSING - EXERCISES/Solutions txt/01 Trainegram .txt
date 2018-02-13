using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\<\[[^A-Za-z0-9]*\]\.)(\.\[[A-Za-z0-9]*\]\.)*$";
            var output = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Traincode!")
                    break;
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    output.Add(m.Value);
                }
            }
            Console.WriteLine(string.Join("\n",output));
        }
    }
}
