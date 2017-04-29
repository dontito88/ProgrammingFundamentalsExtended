namespace Test4._01.SweetDessert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SweetDessert
    {
        public static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var numberOfGuests = decimal.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());

            var numberOfSets = Math.Ceiling(numberOfGuests / 6);

            var productNeededPerSet = (2 * bananaPrice) + (4 * eggsPrice) + (0.2M * berriesPrice);

            var totalProductNeeded = productNeededPerSet * numberOfSets;

            if (cash >= totalProductNeeded)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalProductNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalProductNeeded - cash):F2}lv more.");
            }
        }
    }
}
