namespace Test3._01.SoftUniCoffeeOrders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var totalPrice = 0M;
            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsuleCount = int.Parse(Console.ReadLine());

                var currentPrice = (DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * (long)capsuleCount) * pricePerCapsule;
                totalPrice += currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}