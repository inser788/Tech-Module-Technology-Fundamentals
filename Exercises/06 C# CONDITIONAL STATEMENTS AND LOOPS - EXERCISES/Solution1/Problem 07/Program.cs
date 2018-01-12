using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                string ingredients = Console.ReadLine();
                

                if (ingredients=="Bake!")
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    return;
                }
                count++;
                Console.WriteLine($"Adding ingredient {ingredients}.");
            }
        }
    }
}
