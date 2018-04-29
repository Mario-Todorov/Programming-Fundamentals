using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            int sum = 0;
            string[] hand = Console.ReadLine()
                .Split(':')
                .ToArray();
            string name = "";
            List<string> cards = new List<string>();

            while (hand[0] == "JOKER" == false)
            {
                name = hand[0];
                cards = hand[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();               
                cards = cards.Distinct().ToList();

                if (players.ContainsKey(name) == false)
                {
                    players.Add(name, cards);
                }
                else
                {
                    players[name].AddRange(cards);
                    players[name] = players[name].Distinct().ToList();
                }
                hand = Console.ReadLine()
                     .Split(':')
                     .ToArray();
            }

            int multiplyer = 0;
            int mainValue = 0;

            foreach (var player in players)
            {
                foreach (var card in player.Value)
                {
                    switch (card[card.Length - 1])
                    {
                        case 'S':
                            multiplyer = 4;
                            break;
                        case 'H':
                            multiplyer = 3;
                            break;
                        case 'D':
                            multiplyer = 2;
                            break;
                        case 'C':
                            multiplyer = 1;
                            break;
                    }
                    string current = card.Remove(card.Length - 1, 1);
                    switch (current)
                    {
                        case "J":
                            mainValue = 11;
                            break;
                        case "Q":
                            mainValue = 12;
                            break;
                        case "K":
                            mainValue = 13;
                            break;
                        case "A":
                            mainValue = 14;
                            break;
                        default:
                            mainValue = int.Parse(current);
                            break;
                    }
                    sum += multiplyer * mainValue;
                }
                Console.WriteLine($"{player.Key}: {sum}");
                sum = 0;
            }
        }
    }
}