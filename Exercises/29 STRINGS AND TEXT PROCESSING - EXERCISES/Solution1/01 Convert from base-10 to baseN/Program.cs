using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01_Convert_from_base_10_to_baseN
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            int baseN = int.Parse(input[0]);
            BigInteger numberForConvertBase10 = BigInteger.Parse(input[1]);
            var listOfConvertNumbers = new List<string>();
            while (numberForConvertBase10 != 0)
            {
                BigInteger result = numberForConvertBase10 / baseN;
                string resultString = (numberForConvertBase10 % baseN).ToString();
                listOfConvertNumbers.Add(resultString);
                numberForConvertBase10 = result;
            }
            listOfConvertNumbers.Reverse();
            Console.WriteLine(string.Join("", listOfConvertNumbers));
        }
    }
}
