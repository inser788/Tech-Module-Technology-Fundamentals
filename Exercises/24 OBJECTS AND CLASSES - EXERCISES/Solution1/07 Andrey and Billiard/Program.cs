using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Customer
{
    public string Name { get; set; }
    public Dictionary<string, int> Orders { get; set; }
    public decimal Bill { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var menuList = GetListOfProducts();
        var customers = GetListOfOrdersOfCustomers(menuList);
        PrintAllCustomersAndBills(customers);

    }

    static void PrintAllCustomersAndBills(List<Customer> customers)
    {
        var billTotal = 0m;

        foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.Name}");
            foreach (var product in customer.Orders)
            {
                Console.WriteLine($"-- {product.Key} - {product.Value}");
            }
            Console.WriteLine($"Bill: {customer.Bill:f2}");
            billTotal += customer.Bill;
        }
        Console.WriteLine($"Total bill: {billTotal:f2}");
    }

    static List<Customer> GetListOfOrdersOfCustomers(Dictionary<string, decimal> menuList)
    {
        var customers = new SortedDictionary<string, Customer>();
        var input = Console.ReadLine();
        while (input != "end of clients")
        {
            var currentInput = input.Split(new char[] { '-', ',' }).ToList();
            var customerName = currentInput.First();
            var productName = currentInput.Skip(1).First();
            var quantityCurrent = int.Parse(currentInput.Last());
            if (!menuList.ContainsKey(productName))
            {
                input = Console.ReadLine();
                continue;
            }
            if (!customers.ContainsKey(customerName))
            {
                customers[customerName] = new Customer()
                {
                    Name = customerName,
                    Orders = new Dictionary<string, int>(),
                    Bill = 0m
                };
            }
            if (!customers[customerName].Orders.ContainsKey(productName))
            {
                customers[customerName].Orders[productName] = 0;
            }
            customers[customerName].Orders[productName] += quantityCurrent;
            customers[customerName].Bill += quantityCurrent * menuList[productName];
            input = Console.ReadLine();

        }
        return customers.Select(v => v.Value).ToList();
    }

    static Dictionary<string, decimal> GetListOfProducts()
    {
        int quantityProducts = int.Parse(Console.ReadLine());
        var listOfProductsAndPrice = new Dictionary<string, decimal>();
        for (int i = 0; i < quantityProducts; i++)
        {
            string[] line = Console.ReadLine().Split('-').ToArray();
            string productName = line.First();
            decimal productPrice = decimal.Parse(line.Skip(1).First());
            if (!listOfProductsAndPrice.ContainsKey(productName))
            {
                listOfProductsAndPrice[productName] = 0;
            }

            listOfProductsAndPrice[productName] = productPrice;
        }
        return listOfProductsAndPrice;
    }
}

