using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Nacepin
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal USprice = decimal.Parse(Console.ReadLine())/0.58m;
            int weightUS = int.Parse(Console.ReadLine());
            decimal UKprice = decimal.Parse(Console.ReadLine())/0.41m;
            int weightUK = int.Parse(Console.ReadLine());
            decimal CHprice = decimal.Parse(Console.ReadLine())*0.27m;
            int weightCH = int.Parse(Console.ReadLine());
            string nameUS = "USA";
            string nameUK = "UK";
            string nameChina = "Chinese";

            var listPrices = new Dictionary<string, decimal>
            {
                { "USA",0 },
                {"UK",0 },
                {"Chinese",0 }

            };
            decimal USlevaPrice = USprice / weightUS;
            decimal UKlevaPrice = UKprice / weightUK;
            decimal CHlevaPrice = CHprice / weightCH;

            listPrices[nameUS] += USlevaPrice;
            listPrices[nameUK] += UKlevaPrice;
            listPrices[nameChina] += CHlevaPrice;

            var resultMax = listPrices.Values.Max();
            var resultMin = listPrices.Values.Min();
            var diffrences = resultMax - resultMin;
            var result = listPrices.OrderBy(x => x.Value).ToDictionary(k => k.Key, v => v.Value).Keys.First();
            Console.WriteLine($"{result} store. {resultMin:f2} lv/kg");
            Console.WriteLine($"Difference {diffrences:f2} lv/kg");

        }
    }
}
