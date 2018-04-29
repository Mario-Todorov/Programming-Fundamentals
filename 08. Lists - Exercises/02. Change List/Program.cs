using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<string> commands = Console.ReadLine()
                .Split(' ')
                .ToList();

            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    int numberToDelete = int.Parse(commands[1]);
                    numbers.RemoveAll(i => i == numberToDelete);
                }
                else if (commands[0] == "Insert")
                {
                    int numberToAdd = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, numberToAdd);
                }

                commands = Console.ReadLine()
                    .Split(' ')
                    .ToList();
            }

            if (commands[0] == "Odd")
            {
                foreach (int num in numbers)
                {
                    if (num % 2 == 1)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
            else if (commands[0] == "Even")
            {
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}