using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehieves = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            var hornets = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            long powerHornets = hornets.Sum();
            for (int i = 0; i < beehieves.Count; i++)
            {
                if (beehieves[i]<powerHornets)
                {
                    beehieves[i] = 0;
                }
                else
                {
                    beehieves[i] -= powerHornets;
                    if (hornets.Count == 0)
                        break;
                    hornets.RemoveAt(0);
                    powerHornets = hornets.Sum();
                }
            }
            if (beehieves.Sum()==0)
            {
                Console.WriteLine(string.Join(" ",hornets));
            }
            else
            {
                beehieves.RemoveAll(x => x == 0);
                Console.WriteLine(string.Join(" ",beehieves));
            }
        }
    }
}
