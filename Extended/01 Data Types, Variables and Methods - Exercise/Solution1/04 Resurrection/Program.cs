using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int phoenixAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < phoenixAmount; i++)
            {
                long bodyLength = long.Parse(Console.ReadLine());
                decimal widthBody = decimal.Parse(Console.ReadLine());
                int wingsLength = int.Parse(Console.ReadLine()) * 2;
                decimal yearsReincarnation = (bodyLength * bodyLength) * (widthBody + wingsLength);
                Console.WriteLine(yearsReincarnation);
            }
        }
    }
}
