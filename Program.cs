using System;
using System.Collections.Generic;

namespace Task_12._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>(5)
            {
                new User() {Login = "Iron Man", Name = "Тони Старк", IsPremium = true},
                new User() {Login = "Thor", Name = "Тор Одинсон", IsPremium = false},
                new User() {Login = "Captain America", Name = "Стивен Роджерс", IsPremium = true},
                new User() {Login = "Hulk", Name = "Брюс Беннер", IsPremium = false},
                new User() {Login = "Scarlet Witch", Name = "Ванда Максимофф", IsPremium = true},
            };

            foreach (var user in users)
            {
                Console.Write($"\n{DateTime.Now}\0{user.Login}\0зашел в игру");
                Console.Write("\nРады приветствовать вас: ");
                PrintInColour(user.Name);
                if (!user.IsPremium)
                {
                    Advertisement.ShowAds();
                }
            }
            Console.ReadLine();

            static void PrintInColour(string user_name)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}\n", user_name);
                Console.ResetColor();
            }
        }
    }
}
