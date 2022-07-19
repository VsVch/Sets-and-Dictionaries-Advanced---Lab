using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> contCountCity = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continents = input[0];
                string countries = input[1];
                string cities = input[2];
                if (!contCountCity.ContainsKey(continents))
                {
                    contCountCity.Add(continents, new Dictionary<string, List<string>>());
                }
                if (!contCountCity[continents].ContainsKey(countries))
                {
                    contCountCity[continents][countries] = new List<string>();
                }
                contCountCity[continents][countries].Add(cities);

            }
            foreach (var continent in contCountCity)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var countrie in continent.Value)
                {
                    Console.Write($"  {countrie.Key} -> ");

                    int cityCounter = 0;

                    foreach (var city in countrie.Value)
                    {
                        cityCounter++;

                        if (countrie.Value.Count == cityCounter)
                        {
                            Console.Write($"{city}");
                        }
                        else
                        {
                            Console.Write($"{city}, ");
                        }

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
