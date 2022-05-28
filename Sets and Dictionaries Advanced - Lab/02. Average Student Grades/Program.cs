using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] commandTokens = command.Split(' ');

                string nameOfStudent = commandTokens[0];
                double grade = double.Parse(commandTokens[1]);

                if (!dict.ContainsKey(nameOfStudent))
                {
                    var newList = new List<double>();
                    dict.Add(nameOfStudent, newList);
                }
                dict[nameOfStudent].Add(grade);
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(' ', item.Value):f3} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
