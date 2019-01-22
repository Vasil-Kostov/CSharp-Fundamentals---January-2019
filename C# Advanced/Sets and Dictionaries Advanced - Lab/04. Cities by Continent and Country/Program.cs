namespace _04._Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> continentCountryCity = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentCountryCity.ContainsKey(continent))
                {
                    continentCountryCity.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentCountryCity[continent].ContainsKey(country))
                {
                    continentCountryCity[continent].Add(country, new List<string>());
                }

                continentCountryCity[continent][country].Add(city);
            }

            foreach (var continent in continentCountryCity)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
