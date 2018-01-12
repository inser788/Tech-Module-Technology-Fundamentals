using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Dwarf
{
    public string Name { get; set; }


    public string HatColor { get; set; }

    public int Physic { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        var listOfDwarfs = new List<Dwarf>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Once upon a time")
                break;
            string[] commandLine = input
                .Split(" <:>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string dwarfName = commandLine.First();
            string dwarfHatColor = commandLine.Skip(1).First();
            int dwarfPhysic = int.Parse(commandLine.Last());

            Dwarf dwarf = new Dwarf();
            dwarf.HatColor = dwarfHatColor;
            dwarf.Name = dwarfName;
            dwarf.Physic = dwarfPhysic;

            listOfDwarfs.Add(dwarf);

            listOfDwarfs.Distinct()

            if (listOfDwarfs.Any(dwarf.HatColor==dwarfName.ToString()))
            {
                listOfDwarfs[dwarfHatColor] = new Dictionary<string, int>();
                listOfDwarfs[dwarfHatColor].Add(dwarfName, dwarfPhysic);
            }
            else
            {
                if (!listOfDwarfs[dwarfHatColor].ContainsKey(dwarfName))
                {
                    listOfDwarfs[dwarfHatColor][dwarfName] = dwarfPhysic;
                }
                else
                {
                    listOfDwarfs[dwarfHatColor][dwarfName] = Math.Max(listOfDwarfs[dwarfHatColor][dwarfName], dwarfPhysic);
                }
            }
        }
        var orderedResult = listOfDwarfs.OrderByDescending(x => x.Value.Values.Max())
            .ToDictionary(k => k.Key, v => v.Value);

        foreach (var item in listOfDwarfs)
        {
            foreach (var x in item.Value)
            {
                Console.WriteLine($"({item.Key}) {x.Key} <-> {x.Value}");
            }
        }



        //Console.WriteLine();
    }
}

