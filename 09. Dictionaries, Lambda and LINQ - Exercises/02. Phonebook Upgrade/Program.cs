using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

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
                    case "ListAll":
                        ListAll(phonebook);
                        break;
                    case "END":
                        canContinue = false;
                        break;

                }
            }
        }

        static void AddToPB(SortedDictionary<string, string> phonebook, string[] commands)
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


        static void SearchInPB(SortedDictionary<string, string> phonebook, string[] commands)
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

        static void ListAll(SortedDictionary<string, string> phonebook)
        {
            foreach (KeyValuePair<string, string> entry in phonebook)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}