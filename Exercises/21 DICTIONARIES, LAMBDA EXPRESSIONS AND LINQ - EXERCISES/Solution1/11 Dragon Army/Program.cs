using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DragonType
{
    public string Name { get; set; }

    public long Damage { get; set; }

    public long Health { get; set; }

    public long Armour { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        var dragons = new Dictionary<string, DragonType>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] lineInput = Console.ReadLine().Split().ToArray();
            var dragonType = lineInput.First();
            var dragonName = lineInput.Skip(1).First();
        }

    }

    
}
