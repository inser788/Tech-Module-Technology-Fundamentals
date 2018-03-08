using System;

public class StartUp
{
    static void Main()
    {
        decimal allMoney = decimal.Parse(Console.ReadLine());
        int countStudents = int.Parse(Console.ReadLine());
        decimal sabersPrice = decimal.Parse(Console.ReadLine());
        decimal robesPrice = decimal.Parse(Console.ReadLine());
        decimal beltsPrice = decimal.Parse(Console.ReadLine());

        int sabersCount = (int)Math.Ceiling(countStudents*1.1);
        int robesCount = countStudents;
        int beltsCount = countStudents-(countStudents / 6);

        decimal totalPrice = GetTotalPrice(sabersPrice, sabersCount, robesPrice, robesCount, beltsPrice, beltsCount);

        decimal diffrences = allMoney - totalPrice;

        PrintResult(diffrences, totalPrice);
    }

    private static decimal GetTotalPrice(decimal sabersPrice, int sabersCount, decimal robesPrice, int robesCount, decimal beltsPrice, int beltsCount)
    {
       return  sabersPrice * sabersCount + robesPrice * robesCount + beltsPrice * beltsCount;

    }

    private static void PrintResult(decimal diffrences, decimal totalPrice)
    {
        if (diffrences >= 0)
        {
            Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivan Cho will need {-diffrences:f2}lv more.");
        }
    }
}

