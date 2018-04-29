using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailbook = new Dictionary<string, string>();

            string name = "";
            string email = "";
            string command = Console.ReadLine();

            while (command == "stop" == false)
            {
                name = command;
                email = Console.ReadLine();

                if (mailbook.ContainsKey(name) == false)
                {
                    mailbook.Add(name, email);
                }
                command = Console.ReadLine();
            }

            foreach (var pair in mailbook.Where(pair => pair.Value.EndsWith("us") == false &&
                                                        pair.Value.EndsWith("uk") == false))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}