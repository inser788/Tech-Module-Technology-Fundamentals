﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOk = true;
            var listNameEmail = new Dictionary<string, string>();

            while (isOk)
            {
                var name = Console.ReadLine();
                if (name=="stop")
                {
                    foreach (var item in listNameEmail)
                    {
                        if (item.Value.Contains(".us") || item.Value.Contains(".uk"))
                        {

                        }
                        else
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                    }
                    isOk = false;
                    return;
                }
                var email = Console.ReadLine();
                listNameEmail.Add(name, email);
                
                
            }
        }
    }
}
