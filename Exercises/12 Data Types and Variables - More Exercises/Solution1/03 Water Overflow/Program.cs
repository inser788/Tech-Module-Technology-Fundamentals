using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfIterations = int.Parse(Console.ReadLine());
            double allCapacity = 0;
            for (int i = 0; i < numbersOfIterations; i++)
            {
                double iteration = double.Parse(Console.ReadLine());
                if (iteration>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    if (allCapacity>255)
                    {
                        Console.WriteLine("Insufficient capacity!");
                        continue;

                    }
                    allCapacity += iteration;
                    if (allCapacity>255)
                    {
                        allCapacity -= iteration;
                        Console.WriteLine("Insufficient capacity!");

                        continue;
                    }

                }


            }
            Console.WriteLine(allCapacity);
        }
    }
}
