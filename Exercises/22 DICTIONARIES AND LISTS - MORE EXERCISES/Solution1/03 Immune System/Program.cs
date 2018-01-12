using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHealth = int.Parse(Console.ReadLine());
            var allVirusNames = new List<string>();
            var maxHealth = startHealth;
            var virusName = Console.ReadLine();
            while (virusName!="end")
            {
                var virusPower = 0;
                for (int i = 0; i < virusName.Length; i++)
                {
                    virusPower += virusName[i];
                }
                var secondsForDefeat = virusPower * virusName.Length;
                var healthLeft = startHealth;
                Console.WriteLine($"Virus {virusName}: {virusPower} => {secondsForDefeat} seconds");
                if (!allVirusNames.Contains(virusName))
                {
                    allVirusNames.Add(virusName);
                    var remainingHealth = healthLeft - secondsForDefeat;
                }
            }
        }
    }
}
