namespace ex03.MixedPhones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MixedPhones
    {
        public static void Main()
        {
            var phoneBook = new SortedDictionary<string, decimal>();
            var inputLine = Console.ReadLine();

            while (inputLine != "Over")
            {
                var tokens = inputLine
                    .Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var firstElement = tokens[0];
                var secondElement = tokens[1];

                var phoneNumber = 0m;
                if (decimal.TryParse(firstElement, out phoneNumber))
                {
                    phoneBook[secondElement] = phoneNumber;
                }
                else if (decimal.TryParse(secondElement, out phoneNumber))
                {
                    phoneBook[firstElement] = phoneNumber;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var item in phoneBook)
            {
                var name = item.Key;
                var number = item.Value;
                Console.WriteLine($"{name} -> {number}");
            }
        }
    }
}
