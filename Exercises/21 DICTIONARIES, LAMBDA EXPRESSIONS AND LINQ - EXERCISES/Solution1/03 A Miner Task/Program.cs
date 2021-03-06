﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOk = true;
            var resoursesAndQuantity = new Dictionary<string, decimal>();
            while (isOk)
            {
                var command1 = Console.ReadLine();
                if (command1=="stop")
                {
                    foreach (var item in resoursesAndQuantity)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    isOk = false;
                    return;
                }
                var command2 = decimal.Parse(Console.ReadLine());

                var nameOfResours = command1;
                var quantityOfResours = command2;
                if (resoursesAndQuantity.ContainsKey(nameOfResours))
                {
                    resoursesAndQuantity[nameOfResours] += quantityOfResours;
                }
                else
                {
                    resoursesAndQuantity.Add(nameOfResours, quantityOfResours);

                }
                
            }

        }

        
    }
}
