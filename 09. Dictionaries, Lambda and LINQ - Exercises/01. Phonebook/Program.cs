using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            bool canContinue = true;

            while (canContinue)
            {
                string[] commands = Console.ReadLine().Split(' ');

                switch (commands[0])
                {
                    case "A":
                        AddToPB(phonebook, commands);
                        break;
                    case "S":
                        SearchInPB(phonebook, commands);
                        break;
                    case "END":
                        canContinue = false;
                        break;

                }
            } 
        }

        static void AddToPB (Dictionary<string, string> phonebook, string[] commands)
        {
            if (phonebook.ContainsKey(commands[1]) == false)
            {
                phonebook.Add(commands[1], commands[2]);
            }
            else
            {
                phonebook[commands[1]] = commands[2];
            }
        }


        static void SearchInPB (Dictionary<string, string> phonebook, string[] commands)
        {
            if (phonebook.ContainsKey(commands[1]))
            {
                Console.WriteLine($"{commands[1]} -> {phonebook[commands[1]]}");
            }
            else
            {
                Console.WriteLine($"Contact {commands[1]} does not exist.");
            }
        }

    }
}