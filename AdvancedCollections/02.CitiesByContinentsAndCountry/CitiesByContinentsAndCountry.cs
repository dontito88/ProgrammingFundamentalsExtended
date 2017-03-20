namespace _02.CitiesByContinentsAndCountry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CitiesByContinentsAndCountry
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(' ');
                var continent = inputLine[0];
                var country = inputLine[1];
                var town = inputLine[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();

                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent][country] = new List<string>();
                        continents[continent][country].Add(town);
                    }
                }
            }

            foreach (var continentCountries in continents)

            {
                var continentName = continentCountries.Key;
                var countries = continentCountries.Value;
                Console.WriteLine($"{continentName}:");

                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var cities = countryCities.Value;
                    Console.WriteLine(" {0} -> {1}",
                    countryName, string.Join(", ", cities));
                }
            }
        }
    }
}
