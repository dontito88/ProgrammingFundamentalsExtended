namespace ex04.ExamShopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExamShopping
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var stockDictionary = new SortedDictionary<string, int>();

            while (inputLine != "shopping time")
            {
                var newStock = inputLine.Split();
                var product = newStock[1];
                var quantity = int.Parse(newStock[2]);

                if (!stockDictionary.ContainsKey(product))
                {
                    stockDictionary[product] = 0;
                }
                stockDictionary[product] += quantity;
                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "exam time")
            {
                var buyStock = inputLine.Split();
                var product = buyStock[1];
                var quantity = int.Parse(buyStock[2]);

                if (!stockDictionary.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (stockDictionary[product] <= 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        stockDictionary[product] -= quantity;
                        if (stockDictionary[product] < 0)
                        {
                            stockDictionary[product] = 0;
                        }
                    }
                }
                inputLine = Console.ReadLine();
            }

            foreach (var item in stockDictionary)
            {
                var product = item.Key;
                var quantity = item.Value;

                if (quantity > 0)
                {
                    Console.WriteLine($"{product} -> {quantity}");
                }
            }
        }
    }
}
