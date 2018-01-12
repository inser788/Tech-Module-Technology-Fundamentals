using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new char[] { ',', ' ','\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Demon.Parse).OrderBy(x=>x.Name).ToArray();

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage ");
            }
                
        }
    }
    class Demon
    {
        public string Name { get; set; }

        public decimal Health { get; set; }

        public decimal Damage { get; set; }

        internal static Demon Parse(string demonStr)
        {
            var name = demonStr;
            var healthRegex = new Regex(@"[^\d+\-\/*\.]");         //[^\d\.\+\-\*\/\s\,]
            var damageRegex = new Regex(@"\-?\d+(?:\.\d)?");   //[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)
            var health = healthRegex.Matches(demonStr)
                .Cast<Match>().Select(x => (int)char.Parse(x.Value)).Sum();
            var damage = damageRegex.Matches(demonStr)
                .Cast<Match>().Select(x =>decimal.Parse(x.Value)).Sum();
            var multiplyCount = demonStr.Count(a => a=='*');
            var divideCount = demonStr.Count(a => a == '/');
            damage *= (decimal)Math.Pow(2, multiplyCount);
            damage /= (decimal)Math.Pow(2, divideCount);

            var demon = new Demon()
            {
                Name = name,
                Health = health,
                Damage = damage

            };
            return demon;
        }
    }
}
