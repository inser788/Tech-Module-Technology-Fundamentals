using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exFactor = int.Parse(Console.ReadLine());

            double halfPokePower = pokePower * 0.5;
            int pokeTargets = 0;

            while (pokePower>=distance)
            {
                if (pokePower==halfPokePower&&exFactor!=0)
                {
                    pokePower /= exFactor;
                    if (pokePower<distance)
                    {
                        break;
                    }
                }
                pokePower -= distance;
                pokeTargets++;
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeTargets);
            
        }
    }
}
