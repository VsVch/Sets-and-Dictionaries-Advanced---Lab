using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();
            while (input != "Revision")
            {
                string[] inputArray = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = inputArray[0];
                string product = inputArray[1];
                double price = double.Parse(inputArray[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);
                input = Console.ReadLine();
            }
            foreach (var item in shops)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"Product: {item2.Key}, Price: {item2.Value}");
                }
            }
        }
    }
}
