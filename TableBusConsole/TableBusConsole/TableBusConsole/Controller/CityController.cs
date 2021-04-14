using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableBusConsole.Models;

namespace TableBusConsole.Controller
{
    public static class CityController
    {
        private static string[] Menu = new[]
        {
            "1. Добавить город",
            "2. Изменить информацию о городе",
            "3. Удалить город",
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
                        ShowCities();
                        AddCity();
                        Console.ReadKey();
                        break;
                    case 2:
                        ShowCities();
                        ChangeCity();
                        Console.ReadKey();
                        break;
                    case 3:
                        ShowCities();
                        RemoveCity();
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

        public static void ShowCities()
        {
            Console.WriteLine("===== СПИСОК ГОРОДОВ ======");
            foreach (var city in DataContext.Cities)
            {
                Console.WriteLine($"ID: {city.Id} | Название города: {city.CityName}");
            }
            Console.WriteLine("===========================");
        }

        private static void AddCity()
        {
            Console.WriteLine("Введите название города: ");
            string NameCity = Console.ReadLine();
            if (DataContext.Cities.Where(x => x.CityName == NameCity).FirstOrDefault() == null)
            {
                var City = new City(NameCity);
                DataContext.Cities.Add(City);
                Console.WriteLine("Город добавлен в список");
            }
            else
            {
                Console.WriteLine("Город с таким названием уже имеется в списке");
            }
        }

        private static void ChangeCity()
        {
            Console.WriteLine("Введите ID города: ");
            int iIdCity;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iIdCity));

            if (DataContext.Cities.Find(x => x.Id == iIdCity) != null)
            {
                Console.WriteLine("Введите новое название города: ");
                string NameCity = Console.ReadLine();
                if (DataContext.Cities.Where(x => x.CityName == NameCity).FirstOrDefault() == null)
                {
                    var City = DataContext.Cities.Find(x => x.Id == iIdCity);
                    City.CityName = NameCity;
                    Console.WriteLine("Информация о городе изменена");
                }
                else
                {
                    Console.WriteLine("Город с таким названием уже имеется в списке");
                }
            }
            else
            {
                Console.WriteLine($"Записи с ID: {iIdCity} отсутствуют");
            }
        }

        private static void RemoveCity()
        {
            Console.WriteLine("Введите ID города: ");
            int iIdCity;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iIdCity));

            var city = DataContext.Cities.Find(x => x.Id == iIdCity);
            if (city != null)
            {
                DataContext.Cities.Remove(city);
                Console.WriteLine("Город удален из списка");
            }
            else
            {
                Console.WriteLine($"Записи с ID: {iIdCity} отсутствуют");
            }
        }
    }
}
