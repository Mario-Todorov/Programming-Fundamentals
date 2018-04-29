using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbrers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            string[] commands = Console.ReadLine()
                .Split(' ')
                .ToArray();

            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    int index = int.Parse(commands[1]);
                    long element = long.Parse(commands[2]);

                    numbrers.Insert(index, element);
                }
                else if (commands[0] == "addMany")
                {
                    int index = int.Parse(commands[1]);
                    long[] elements = new long[commands.Length - 2];
                    for (int i = 2; i < commands.Length; i++)
                    {
                        elements[i - 2] = int.Parse(commands[i]);
                    }
                    numbrers.InsertRange(index, elements);
   
                 }
                else if (commands[0] == "contains")
                {
                    int index = int.Parse(commands[1]);
                    int check = 0;

                    for (int i = 0; i < numbrers.Count; i++)
                    {
                        if (numbrers[i] == index)
                        {
                            Console.WriteLine(i);
                            check = 1;
                            break;
                        }
                    }

                    if (check == 0)
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (commands[0] == "remove")
                {
                    int index = int.Parse(commands[1]);
                    numbrers.RemoveAt(index);
                }
                else if (commands[0] == "shift")
                {
                    int positions = int.Parse(commands[1]);
                    if (positions > numbrers.Count - 1)
                    {
                        positions = positions % numbrers.Count;
                    }
                    long[] firstElements = new long[positions];
                    long[] secondElements = new long[numbrers.Count - positions];
                    for (int i = 0; i < positions; i++)
                    {
                        firstElements[i] = numbrers[i]; 
                    }
                    for (int i = positions; i < numbrers.Count; i++)
                    {
                        secondElements[i - positions] = numbrers[i];
                    }
                    numbrers.RemoveRange(0, numbrers.Count);
                    numbrers.AddRange(secondElements);
                    numbrers.AddRange(firstElements);
                }
                else if (commands[0] == "sumPairs")
                {
                    List<long> sumPairs = new List<long>();

                    if (numbrers.Count % 2 == 0)
                    {
                        for (int i = 0; i < numbrers.Count; i += 2)
                        {
                            sumPairs.Add(numbrers[i] + numbrers[i + 1]);
                        }

                        numbrers.RemoveRange(0, numbrers.Count);
                        numbrers.AddRange(sumPairs);
                    }
                    else
                    {
                        for (int i = 0; i < numbrers.Count - 1; i += 2)
                        {
                            sumPairs.Add(numbrers[i] + numbrers[i + 1]);
                        }

                        numbrers.RemoveRange(0, numbrers.Count - 1);
                        numbrers.InsertRange(0, sumPairs);
                    }

                }

                commands = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", numbrers)}]");
        }
    }
}