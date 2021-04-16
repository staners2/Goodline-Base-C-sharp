using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableBusConsole.Models;

namespace TableBusConsole.Controller
{
    public static class RouteController
    {
        private static string[] Menu = new[]
        {
            "1. Добавить маршрут",
            "2. Изменить информацию о маршруте",
            "3. Удалить маршрут",
            "4. Покинуть раздел"
        };

        public static void ShowMenu()
        {
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

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        ShowRoutes();
                        AddRoute();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        ShowRoutes();
                        ChangeRoute();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        ShowRoutes();
                        RemoveRoute();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        IsExit = true;
                        break;
                }
            } while (!IsExit);
        }

        public static void ShowRoutes()
        {
            Console.WriteLine("================================= СПИСОК МАРШРУТОВ =================================");
            Console.WriteLine(" ID | Название | Город(отбытия) | Город(прибытия) |   Расстояние  |  Время в пути  |");
            foreach (var route in DataContext.Routes)
            {
                Console.WriteLine($"{route.Id,4}|{route.NameRoute,10}|{DataContext.Cities.Where(x => x.Id == route.CityStart).FirstOrDefault().CityName,16}|" +
                                  $"{DataContext.Cities.Where(x => x.Id == route.CityEnd).FirstOrDefault().CityName,17}|" +
                                  $"{route.Distance,12}km |{route.TravelTime,16}|");
            }
            Console.WriteLine("====================================================================================");
        }

        private static void AddRoute()
        {
            Console.WriteLine("Введите название маршрута");
            string NameRoute;
            NameRoute = Console.ReadLine();
            if (DataContext.Routes.Where(x => x.NameRoute == NameRoute).FirstOrDefault() != null)
            {
                Console.WriteLine("Маршрут с таким названием уже присутствует");
                return;
            }

            CityController.ShowCities();
            Console.WriteLine("Введите ID города(откуда): ");
            int iIdCityStart;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iIdCityStart));
            if (DataContext.Cities.Find(x => x.Id == iIdCityStart) == null)
            {
                Console.WriteLine($"Города с ID: {iIdCityStart} отсутствует");
                return;
            }

            Console.WriteLine("Введите ID города(куда): ");
            int iIdCityEnd;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iIdCityEnd));
            if (DataContext.Cities.Find(x => x.Id == iIdCityEnd) == null)
            {
                Console.WriteLine($"Города с ID: {iIdCityEnd} отсутствует");
                return;
            }

            if (iIdCityStart == iIdCityEnd)
            {
                Console.WriteLine("ID городов не должны повторяться");
                return;
            }

            Console.WriteLine("Введите расстояние между городами (в км): ");
            double Distance;
            do
            {

            } while (!double.TryParse(Console.ReadLine(), out Distance));

            Console.WriteLine("Введите время в пути (формат: часы:минуты:секунды)");
            TimeSpan TimeTravel;
            try
            {
                TimeTravel = TimeSpan.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели время не по формату");
                return;
            }

            Route route = new Route(NameRoute, iIdCityStart, iIdCityEnd, Distance, TimeTravel);
            DataContext.Routes.Add(route);
            Console.WriteLine("Маршрут добавлен");
        }

        private static void ChangeRoute()
        {
            Console.WriteLine("Введите ID маршрута: ");
            int iIdRoute;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iIdRoute));

            if (DataContext.Cities.Find(x => x.Id == iIdRoute) != null)
            {
                Console.WriteLine("Введите название маршрута");
                string NameRoute;
                NameRoute = Console.ReadLine();
                if (DataContext.Routes.Where(x => x.NameRoute == NameRoute).FirstOrDefault() != null)
                {
                    Console.WriteLine("Маршрут с таким названием уже присутствует");
                    return;
                }

                Console.WriteLine("Введите ID города(откуда): ");
                int iIdCityStart;
                do
                {

                } while (!int.TryParse(Console.ReadLine(), out iIdCityStart));
                if (DataContext.Cities.Find(x => x.Id == iIdCityStart) == null)
                {
                    Console.WriteLine($"Города с ID: {iIdCityStart} отсутствует");
                    return;
                }

                Console.WriteLine("Введите ID города(куда): ");
                int iIdCityEnd;
                do
                {

                } while (!int.TryParse(Console.ReadLine(), out iIdCityEnd));
                if (DataContext.Cities.Find(x => x.Id == iIdCityEnd) == null)
                {
                    Console.WriteLine($"Города с ID: {iIdCityEnd} отсутствует");
                    return;
                }

                if (iIdCityStart == iIdCityEnd)
                {
                    Console.WriteLine("ID городов не должны повторяться");
                    return;
                }

                Console.WriteLine("Введите расстояние между городами (в км): ");
                double Distance;
                do
                {

                } while (!double.TryParse(Console.ReadLine(), out Distance));

                Console.WriteLine("Введите время в пути (формат: часы:минуты:секунды)");
                TimeSpan TimeTravel;
                try
                {
                    TimeTravel = TimeSpan.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели время не по формату");
                    return;
                }

                City CityStart = DataContext.Cities.Find(x => x.Id == iIdCityStart);
                City CityEnd = DataContext.Cities.Find(x => x.Id == iIdCityEnd);

                Route route = DataContext.Routes.Find(x => x.Id == iIdRoute);
                route.NameRoute = NameRoute;
                route.CityStart = iIdCityStart;
                route.CityEnd = iIdCityEnd;
                route.Distance = Distance;
                route.TravelTime = TimeTravel;
                route.pCityStart = CityStart;
                route.pCityEnd = CityEnd;
                Console.WriteLine("Информация о маршруте изменена");
            }
            else
            {
                Console.WriteLine($"Записи с ID: {iIdRoute} отсутствуют");
            }
        }

        private static void RemoveRoute()
        {
            Console.WriteLine("Введите ID маршрута: ");
            int iIdRoute;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iIdRoute));

            var route = DataContext.Routes.Find(x => x.Id == iIdRoute);
            if (route != null)
            {
                DataContext.Routes.Remove(route);
                Console.WriteLine("Маршрут удален из списка");
            }
            else
            {
                Console.WriteLine($"Записи с ID: {iIdRoute} отсутствуют");
            }
        }
    }
}
