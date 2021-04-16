using System;
using System.Collections.Generic;
using System.Text;
using TableBusConsole.Controller;

namespace TableBusConsole
{
    public static class MenuController
    {
        private static string[] MenuUser = new[]
        {
            "1. Просмотр расписания",
            "2. Записаться на рейс",
            "3. Информация об аккаунте)",
            "4. Пополнение баланса",
            "5. Выход"
        };

        private static string[] MenuAdmin = new[]
        {
            "1. Просмотр расписания",
            "2. Записаться на рейс",
            "3. Информация об аккаунте",
            "4. Модерация городов",
            "5. Модерация маршрутов",
            "6. Модерация расписания рейсов",
            "7. Пополнение баланса",
            "8. Выход"
        };

        private static void ShowMenuUser()
        {
            bool IsExit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                foreach (var elem in MenuUser)
                {
                    Console.WriteLine($"{elem}");
                }
                Console.WriteLine("====================");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        TableController.ShowTables(DataContext.Tables);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        FlightController.RecordFlight();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        AccountController.ShowUserInfo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        AccountController.GiveMoneyForAccount(AccountController.User.Id);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        IsExit = true;
                        break;
                }
            } while (!IsExit);
        }

        private static void ShowMenuAdmin()
        {
            bool IsExit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                foreach (var elem in MenuAdmin)
                {
                    Console.WriteLine($"{elem}");
                }
                Console.WriteLine("====================");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        TableController.ShowTables(DataContext.Tables);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        FlightController.RecordFlight();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        AccountController.ShowUserInfo();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        CityController.ShowMenu();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        RouteController.ShowMenu();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Console.Clear();
                        TableController.ShowMenu();
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        Console.Clear();
                        AccountController.GiveMoneyForAccount(AccountController.User.Id);
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        Console.Clear();
                        IsExit = true;
                        break;
                }
            } while (!IsExit);
        }

        public static void Start()
        {
            if (AccountController.User.IsAdmin)
            {
                ShowMenuAdmin();
            }
            else
            {
                ShowMenuUser();
            }
            
        }
    }
}
