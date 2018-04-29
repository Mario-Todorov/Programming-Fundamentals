using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> informtion = new SortedDictionary<string, SortedDictionary<string, int>>();
            int countOfLogLines = int.Parse(Console.ReadLine());
            string user = null;
            string ip = null;
            int duration = 0;

            for (int i = 0; i < countOfLogLines; i++)
            {
                string[] logLine = Console.ReadLine().Split(' ').ToArray();

                user = logLine[1];
                ip = logLine[0];
                duration = int.Parse(logLine[2]);

                if (informtion.ContainsKey(user) == false)
                {
                    SortedDictionary<string, int> helper = new SortedDictionary<string, int>();
                    helper.Add(ip, duration);
                    informtion.Add(user, helper);
                }
                else
                {
                    if (informtion[user].ContainsKey(ip) == false)
                    {
                        informtion[user].Add(ip, duration);
                    }
                    else
                    {
                        informtion[user][ip] += duration;
                    }
                }
            }


            foreach (var pair in informtion)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Values.Sum()} [{string.Join(", ", pair.Value.Keys)}]");
            }
        }
    }
}