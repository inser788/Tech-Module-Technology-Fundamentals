
using System;

public class StartUp
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        long combinations =(long)Math.Pow((endNumber - startNumber) + 1,2) ;

        int counter = 0;
        for (int i = startNumber; i <=endNumber; i++)
        {
            for (int j = startNumber; j <=endNumber; j++)
            {
                counter++;
                if (i+j==magicNumber)
                {
                    Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                    return;
                }
            }
        }

        Console.WriteLine($"{combinations} combinations - neither equals {magicNumber} ");
    }
}

