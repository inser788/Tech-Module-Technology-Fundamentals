using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceJewAndGold = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long priceJew = priceJewAndGold[0];
            long priceGold = priceJewAndGold[1];
            long allExpenses = 0l;
            int countJew = 0;
            int countGold = 0;
            long totlPriceLoots = 0l;
            long difference = 0l;

            for (int i = 0; i < 20; i++)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Jail")
                {
                    break;
                }
                var loots = command[0];
                var expences = long.Parse(command[1]);
                allExpenses += expences;
                for (int j = 0; j < loots.Length; j++)
                {
                    if (loots[j] == '%')
                    {
                        countJew++;
                    }
                    else if (loots[j] == '$')
                    {
                        countGold++;
                    }
                }
            }
            totlPriceLoots = (priceJew * countJew) + (priceGold * countGold);
            difference = totlPriceLoots - allExpenses;

            if (difference >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {difference}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {-difference}.");
            }







        }
    }
}
