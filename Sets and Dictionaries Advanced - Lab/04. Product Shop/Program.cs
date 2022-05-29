using System;
using System.Collections.Generic;
using System.Linq;


namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "Revision")
            {
                string[] inputs = cmd.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string shop = inputs[0];
                string product = inputs[1];
                double price = double.Parse(inputs[2]);

                if (!shops.ContainsKey(shop))
                {
                    var newProductsDict = new Dictionary<string, double>();
                    shops.Add(shop, newProductsDict);
                }
                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops[shop][product] = price;
                }
            }

            var orderedShops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach(var shop in orderedShops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach(var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
