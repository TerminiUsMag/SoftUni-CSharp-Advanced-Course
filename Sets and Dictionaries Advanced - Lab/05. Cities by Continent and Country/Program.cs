using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var map = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<n; i++)
            {
                string[] inputs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string continent = inputs[0];
                string country = inputs[1];
                string city = inputs[2];

                if (!map.ContainsKey(continent))
                {
                    var newCountryDict = new Dictionary<string, List<string>>();
                    map.Add(continent, newCountryDict);
                }

                if (!map[continent].ContainsKey(country))
                {
                    var newCitiesList = new List<string>();
                    map[continent].Add(country, newCitiesList);
                }

                map[continent][country].Add(city); 
            }
            foreach(var continent in map)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach(var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }



        }
    }
}
