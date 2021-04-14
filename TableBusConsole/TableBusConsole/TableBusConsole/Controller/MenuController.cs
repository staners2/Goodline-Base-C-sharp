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
            "4. Выход"
        };

        private static string[] MenuAdmin = new[]
        {
            "1. Просмотр расписания",
            "2. Записаться на рейс",
            "3. Информация об аккаунте",
            "4. Модерация городов",
            "5. Модерация маршрутов",
            "6. Модерация расписания рейсов",
            "7. Выход"
        };

        private static void ShowMenuUser()
        {
            bool IsExit = false;
            do
            {
                int iNumberPick;
                Console.Clear();
                Console.WriteLine("====================");
                foreach (var elem in MenuUser)
                {
                    Console.WriteLine($"{elem}");
                }
                Console.WriteLine("====================");

                if (!int.TryParse(Console.ReadLine(), out iNumberPick))
                {
                    continue;
                }

                Console.Clear();

                switch (iNumberPick)
                {
                    case 1:
                        TableController.ShowTables(DataContext.Tables);
                        Console.ReadKey();
                        break;
                    case 2:
                        FlightController.RecordFlight();
                        Console.ReadKey();
                        break;
                    case 3:
                        AccountController.ShowUserInfo();
                        Console.ReadKey();
                        break;
                    case 4:
                        IsExit = true;
                        break;
                    default:
                        Console.WriteLine("Ошибка! Неверный пункт меню!");
                        break;
                }
            } while (!IsExit);
        }

        private static void ShowMenuAdmin()
        {
            bool IsExit = false;
            do
            {
                int iNumberPick;
                Console.Clear();
                Console.WriteLine("====================");
                foreach (var elem in MenuAdmin)
                {
                    Console.WriteLine($"{elem}");
                }
                Console.WriteLine("====================");

                if (!int.TryParse(Console.ReadLine(), out iNumberPick))
                {
                    continue;
                }

                Console.Clear();

                switch (iNumberPick)
                {
                    case 1:
                        TableController.ShowTables(DataContext.Tables);
                        Console.ReadKey();
                        break;
                    case 2:
                        FlightController.RecordFlight();
                        Console.ReadKey();
                        break;
                    case 3:
                        AccountController.ShowUserInfo();
                        Console.ReadKey();
                        break;
                    case 4:
                        CityController.ShowMenu();
                        break;
                    case 5:
                        RouteController.ShowMenu();
                        break;
                    case 6:
                        TableController.ShowMenu();
                        break;
                    case 7:
                        IsExit = true;
                        break;
                    default:
                        Console.WriteLine("Ошибка! Неверный пункт меню!");
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
