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

        decimal totalPrice = sabersPrice * sabersCount + robesPrice * robesCount + beltsPrice * beltsCount;

        decimal diffrences = allMoney - totalPrice;
        if (diffrences>=0)
        {
            Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivan Cho will need {-diffrences:f2}lv more.");
        }
    }
}

