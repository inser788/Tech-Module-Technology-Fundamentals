using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = Console.ReadLine();
            int characterCurrentHealth = int.Parse(Console.ReadLine());
            int characterMaxHealth = int.Parse(Console.ReadLine());
            int characterCurrentEnergy = int.Parse(Console.ReadLine());
            int characterMaxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {characterName}");
            Console.Write("Health: ");
            Console.WriteLine("|{0}{1}|",
                new string('|', characterCurrentHealth),
                new string('.', characterMaxHealth - characterCurrentHealth));
            Console.Write("Energy: ");
            Console.WriteLine("|{0}{1}|",
    new string('|', characterCurrentEnergy),
    new string('.', characterMaxEnergy - characterCurrentEnergy));

        }
    }
}
