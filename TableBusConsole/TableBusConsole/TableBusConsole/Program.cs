using System;
using TableBusConsole.Controller;

namespace TableBusConsole
{
    class Program
    {
        private static string[] Menu =
        {
            "1. Войти в аккаунт",
            "2. Выйти"
        };
        static void Main(string[] args)
        {
            GenerateRecords.Generate();
            bool IsExit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                foreach (var elem in Menu)
                {
                    Console.WriteLine($"{elem}");
                }
                Console.WriteLine("====================");

                switch (Console.ReadKey().Key) //iNumberPick
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        AccountController.EnterAccount();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        IsExit = true;
                        break;
                }
            } while (!IsExit);
            Console.Clear();
            Console.WriteLine("=> Вы покинули приложение <=");
            Console.ReadKey();
        }
    }
}
