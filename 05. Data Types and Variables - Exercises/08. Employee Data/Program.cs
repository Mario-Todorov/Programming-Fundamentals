using System;

namespace _08._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine());
            int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\r\nLast name: {lastName}" +
                $"\r\nAge: {age}\r\nGender: {gender}\r\nPersonal ID: {personalID}" +
                $"\r\nUnique Employee number: {uniqueEmployeeNumber}");
        }
    }
}