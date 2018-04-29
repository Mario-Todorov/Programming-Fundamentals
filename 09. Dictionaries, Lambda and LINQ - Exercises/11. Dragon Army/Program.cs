using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, double[]>> typeNameStats = new Dictionary<string, SortedDictionary<string, double[]>>();

            int numberOfDragons = int.Parse(Console.ReadLine());
            string type = null;
            string name = null;
            double damage = 0;
            double health = 0;
            double armor = 0;
            double averageDamage = 0;
            double averageHealth = 0;
            double averageArmor = 0;
            int counter = 0;


            for (int i = 0; i < numberOfDragons; i++)
            {
                string input = Console.ReadLine();

                string[] inputSplit = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                type = inputSplit[0];
                name = inputSplit[1];


                if (inputSplit[2] == "null" == false)  { damage = double.Parse(inputSplit[2]); }
                else  { damage = 45; }

                if (inputSplit[3] == "null" == false) { health = double.Parse(inputSplit[3]); }
                else { health = 250; }

                if (inputSplit[4] == "null" == false) { armor = double.Parse(inputSplit[4]); }
                else { armor = 10; }
                

                double[] stats = { damage, health, armor };

                if (typeNameStats.ContainsKey(type) == false)
                {
                    SortedDictionary <string, double[]> nameStats = new SortedDictionary<string, double[]>();
                    nameStats.Add(name, stats);
                    typeNameStats.Add(type, nameStats);                   
                }
                else
                {
                    if (typeNameStats[type].ContainsKey(name) == false)
                    {
                        typeNameStats[type].Add(name, stats);
                    }
                    else
                    {
                        typeNameStats[type][name] = stats;
                    }
                }
            }

            foreach (var typeName in typeNameStats)
            {
                foreach (var nameStats in typeName.Value)
                {
                    averageDamage += nameStats.Value[0];
                    averageHealth += nameStats.Value[1];
                    averageArmor += nameStats.Value[2];
                }

                averageDamage = averageDamage / typeName.Value.Count();
                averageHealth = averageHealth / typeName.Value.Count();
                averageArmor = averageArmor / typeName.Value.Count();

                Console.WriteLine($"{typeName.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

                foreach (var nameStats in typeName.Value)
                {
                    Console.WriteLine($"-{nameStats.Key} -> damage: {nameStats.Value[0]}, health: {nameStats.Value[1]}, armor: {nameStats.Value[2]}");
                }

                averageDamage = 0;
                averageHealth = 0;
                averageArmor = 0;
            }
        }
    }
}