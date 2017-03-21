
namespace _04.GroupContinentsCountriesCities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupContinentsCountriesCities
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var continentData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(' ');
                var continent = inputLine[0];
                var country = inputLine[1];
                var town = inputLine[2];

                if (!continentData.ContainsKey(continent))
                {
                    continentData[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!continentData[continent].ContainsKey(country))
                {
                    continentData[continent][country] = new SortedSet<string>();
                }

                continentData[continent][country].Add(town);
            }

            foreach (var content in continentData)
            {
                var continentName = content.Key;
                var countryName = content.Value;
                Console.WriteLine($"{continentName}:");

                foreach (var item in countryName)
                {
                    var country = item.Key;
                    var town = item.Value;
                    Console.WriteLine($"  {country} -> {string.Join(", ", town)}");
                }
            }
        }
    }
}
