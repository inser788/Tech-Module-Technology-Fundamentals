using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = Math.Min(firstNumber,secondNumber); i <= Math.Max(firstNumber, secondNumber); i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
