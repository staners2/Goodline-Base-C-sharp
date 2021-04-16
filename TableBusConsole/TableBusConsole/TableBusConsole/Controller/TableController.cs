using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableBusConsole.Controller;
using TableBusConsole.Models;

namespace TableBusConsole
{
    public static class TableController
    {

        private static string[] Menu = new[]
        {
            "1. Добавить запись в расписание",
            "2. Изменить информацию о записи в расписании",
            "3. Удалить запись из расписания",
            "4. Покинуть раздел"
        };

        public static void ShowMenu()
        {
            bool IsExit = false;
            do
            {
                int iNumberPick;
                Console.Clear();
                Console.WriteLine("====================");
                foreach (var elem in Menu)
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
                        ShowTables();
                        AddTable();
                        Console.ReadKey();
                        break;
                    case 2:
                        ShowTables();
                        ChangeTable();
                        Console.ReadKey();
                        break;
                    case 3:
                        ShowTables();
                        RemoveTable();
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

        public static void ShowTables()
        {
            {
                Console.WriteLine("============================================" +
                                  " РАСПИСАНИЕ " +
                                  "============================================");
                Console.WriteLine(" ID | Город(откуда) | Город(куда) | Свободных мест | PRICE |    Дата(начало)   |    Дата(конец)    |");
                foreach (var table in DataContext.Tables)
                {
                    Console.WriteLine($"{table.Id,4}|{table.Route.pCityStart.CityName,15}|{table.Route.pCityEnd.CityName,13}|{table.MaxCountPassenger - table.CurrentCountPassenger,16}|" +
                                      $"{table.Price,7}|{table.DateTimeStart,19}|{table.DateTimeEnd,19}|");
                    Console.WriteLine();
                }

                Console.WriteLine("====================================================================================================");
            }
        }

        private static void AddTable()
        {
            RouteController.ShowRoutes();
            CityController.ShowCities();
            Console.WriteLine("Введите ID записи в расписании: ");
            int iIdRoute;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iIdRoute));
            if (DataContext.Routes.Find(x => x.Id == iIdRoute) == null)
            {
                Console.WriteLine($"Маршрут с ID: {iIdRoute} отсутствует");
                return;
            }

            Console.WriteLine("Введите дату и время рейса(формат: месяц/день/год часы:минуты:секунды)");
            DateTime dateTimeStart;
            try
            {
                dateTimeStart = DateTime.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели дату и время не по формату");
                return;
            }
            if (dateTimeStart < DateTime.Now)
            {
                Console.WriteLine("Дата выезда не может быть прошедшым");
                return;
            }

            DateTime dateTimeEnd = dateTimeStart.Add(DataContext.Routes.Find(x => x.Id == iIdRoute).TravelTime);

            Console.WriteLine("Введите максимальное кол-во мест: ");
            int iMaxCountPassenger;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iMaxCountPassenger));

            if (iMaxCountPassenger <= 0)
            {
                Console.WriteLine("Ошибка в вводе максимального кол-ва пассажиров");
                return;
            }

            Console.WriteLine("Введите стоимость билета(rub): ");
            int iPrice;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iPrice));

            if (iPrice <= 0)
            {
                Console.WriteLine("Ошибка в вводе стоимости билета");
                return;
            }

            Table table = new Table(dateTimeStart, dateTimeEnd, iMaxCountPassenger, iPrice, iIdRoute);
            DataContext.Tables.Add(table);
            Console.WriteLine("Запись в расписании создана");

        }

        private static void ChangeTable()
        {
            Console.WriteLine("Введите ID записи в расписании: ");
            int iIdTable;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iIdTable));

            var table = DataContext.Tables.Find(x => x.Id == iIdTable);
            if (table != null)
            {
                RouteController.ShowRoutes();
                CityController.ShowCities();
                Console.WriteLine("Введите ID маршрута: "); 
                int iIdRoute;
                do
                {

                } while (!int.TryParse(Console.ReadLine(), out iIdRoute));
                if (DataContext.Routes.Find(x => x.Id == iIdRoute) == null)
                {
                    Console.WriteLine($"Маршрут с ID: {iIdRoute} отсутствует");
                    return;
                }

                Console.WriteLine("Введите дату и время рейса(формат: месяц/день/год часы:минуты:секунды)");
                DateTime dateTimeStart;
                try
                {
                    dateTimeStart = DateTime.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели дату и время не по формату");
                    return;
                }

                if (dateTimeStart < DateTime.Now)
                {
                    Console.WriteLine("Дата выезда не может быть прошедшим");
                    return;
                }

                DateTime dateTimeEnd = dateTimeStart.Add(DataContext.Routes.Find(x => x.Id == iIdRoute).TravelTime);

                Console.WriteLine("Введите максимальное кол-во мест: ");
                int iMaxCountPassenger;
                do
                {

                } while (!int.TryParse(Console.ReadLine(), out iMaxCountPassenger));

                if (iMaxCountPassenger <= 0)
                {
                    Console.WriteLine("Ошибка в вводе максимального кол-ва пассажиров");
                    return;
                }

                Console.WriteLine("Введите стоимость билета(rub): ");
                int iPrice;
                do
                {

                } while (!int.TryParse(Console.ReadLine(), out iPrice));

                if (iPrice <= 0)
                {
                    Console.WriteLine("Ошибка в вводе стоимости билета");
                    return;
                }

                table.DateTimeStart = dateTimeStart;
                table.DateTimeEnd = dateTimeEnd;
                table.CurrentCountPassenger = iMaxCountPassenger;
                table.Route = DataContext.Routes.Find(x => x.Id == iIdRoute);
                table.Price = iPrice;
                DataContext.Tables.Add(table);
                Console.WriteLine("Информация о рейсе в расписании изменена");
            }
            else
            {
                Console.WriteLine($"Записи с ID: {iIdTable} отсутствуют");
            }
        }

        private static void RemoveTable()
        {
            Console.WriteLine("Введите ID записи в расписании: ");
            int iIdTable;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iIdTable));

            var table = DataContext.Tables.Find(x => x.Id == iIdTable);
            if (table != null)
            {
                DataContext.Tables.Remove(table);
                Console.WriteLine("Запись из расписания удалена");
            }
            else
            {
                Console.WriteLine($"Записи с ID: {iIdTable} отсутствуют");
            }
        }

        public static void ShowTables(List<Table> Tables)
        {
            Console.WriteLine("============================================" +
                              " РАСПИСАНИЕ " +
                              "============================================");
            Console.WriteLine(" ID | Город(откуда) | Город(куда) | Свободных мест | PRICE |    Дата(начало)   |    Дата(конец)    |");
            foreach (var table in Tables)
            {
                Console.WriteLine($"{table.Id,4}|{table.Route.pCityStart.CityName,15}|{table.Route.pCityEnd.CityName,13}|{table.MaxCountPassenger - table.CurrentCountPassenger,16}|" +
                                  $"{table.Price,7}|{table.DateTimeStart,19}|{table.DateTimeEnd,19}|");
                Console.WriteLine();
            }

            Console.WriteLine("====================================================================================================");
        }
    }
}
