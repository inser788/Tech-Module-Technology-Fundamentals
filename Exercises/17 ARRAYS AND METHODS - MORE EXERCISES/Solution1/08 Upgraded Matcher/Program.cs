﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameOfProducts = Console.ReadLine().Split().ToArray();
            long[] quantityOfProducts = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] priceOfProducts = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            long currentQuantity = 0l;
            decimal totalPriceProduct = 0m;
            for (int i = 0; i < int.MaxValue; i++)
            {
                string[] currentProductAndQuantity = Console.ReadLine().Split().ToArray();
               
                string currentProduct = currentProductAndQuantity[0];
                if (currentProduct == "done")
                {
                    return;
                }
                long quantityCurrentProduct = long.Parse(currentProductAndQuantity[1]);
               
                int index = Array.IndexOf(nameOfProducts, currentProduct);
                if (index>=quantityOfProducts.Length)
                {
                    currentQuantity = 0;
                    Console.WriteLine($"We do not have enough {currentProduct}");
                }
                else
                {
                    currentQuantity = quantityCurrentProduct;
                    if (quantityCurrentProduct>quantityOfProducts[index])
                    {
                        Console.WriteLine($"We do not have enough {currentProduct}");

                    }
                    else
                    {
                        quantityOfProducts[index] -= quantityCurrentProduct;
                        if (quantityOfProducts[index]<0)
                        {
                            Console.WriteLine($"We do not have enough {currentProduct}");

                        }
                        else
                        {
                            totalPriceProduct = priceOfProducts[index] * quantityCurrentProduct;
                            Console.WriteLine($"{currentProduct} x {quantityCurrentProduct} costs {totalPriceProduct:f2}");
                        }
                    }
                }
                
            }
        }
    }
}
