using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequance = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            long sumAll = 0;
            while (true)
            {
                if (sequance.Count == 0)
                    break;
                int inputIndex = int.Parse(Console.ReadLine());
                if (inputIndex < 0)
                {
                    inputIndex = 0;
                    sequance.Insert(1, sequance.Last());
                }
                if (inputIndex>sequance.Count-1)
                {
                    inputIndex = sequance.Count;
                    sequance.Insert(sequance.Count - 1, sequance.First());

                }
                int removedElement = sequance[inputIndex];
                sumAll += removedElement;
                sequance.RemoveAt(inputIndex);
                for (int i = 0; i < sequance.Count; i++)
                {
                    
                    if (sequance[i] <= removedElement)
                    {
                        sequance[i] += removedElement;
                    }
                    else
                    {
                        sequance[i] -= removedElement;
                    }

                }
            }
            Console.WriteLine(sumAll);
        }
    }
}
