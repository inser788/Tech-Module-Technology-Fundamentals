using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyHave = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal priceBananas = decimal.Parse(Console.ReadLine()) * 2;
            decimal priceEggs = decimal.Parse(Console.ReadLine()) * 4;
            decimal priceBerries = decimal.Parse(Console.ReadLine()) * 0.2m;
            if (numberOfGuests % 6 == 0)
            {
                decimal numberOfPortionsSet = (numberOfGuests / 6);
                decimal totalMoneyNeed = (priceBananas + priceBerries + priceEggs) * numberOfPortionsSet;
                GetMoneyLeftAndPrint(moneyHave, totalMoneyNeed);
            }
            else
            {
                decimal numberOfPortionsSet = (numberOfGuests / 6) + 1;
                decimal totalMoneyNeed = (priceBananas + priceBerries + priceEggs) * numberOfPortionsSet;
                GetMoneyLeftAndPrint(moneyHave, totalMoneyNeed);
            }
        }

        static void GetMoneyLeftAndPrint(decimal moneyHave, decimal totalMoneyNeed)
        {
            var moneyLeft = moneyHave - totalMoneyNeed;
            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalMoneyNeed:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {-moneyLeft:f2}lv more.");
            }
        }
    }
}
