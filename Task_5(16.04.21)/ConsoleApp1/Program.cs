using System;
using Library;
using Library.Models;

namespace ConsoleApp1
{
    class Program
    {
        private static string[] Menu =
        {
            "======= ГОРОД =======",
            "1. Просмотр городов",
            "2. Добавить город",
            "3. Изменить информацию",
            "4. Удалить информацию",
            "======================",
            "====== МАРШРУТ =======",
            "5. Просмотр маршрутов",
            "6. Добавить маршрут",
            "7. Изменить информацию",
            "8. Удалить информацию",
            "======================",
            "       9. EXIT        "
        };
        static void Main(string[] args)
        {
            DataBase.Start();
            bool IsExit = false;
            do
            {
                Console.Clear();
                foreach (var elem in Menu)
                {
                    Console.WriteLine($"{elem}");
                }

                switch (Console.ReadKey().Key) //iNumberPick
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        ShowCities();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        ShowCities();
                        AddCity();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        ShowCities();
                        ChangeCity();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        ShowCities();
                        DeleteCity();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        ShowRoutes();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Console.Clear();
                        ShowRoutes();
                        AddRoute();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        Console.Clear();
                        ShowRoutes();
                        ChangeRoute();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        Console.Clear();
                        ShowRoutes();
                        DeleteRoute();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        IsExit = true;
                        break;
                }
            } while (!IsExit);
            Console.Clear();
            Console.WriteLine("=> Вы покинули приложение <=");
            Console.ReadKey();
        }

        public static void ShowCities()
        {
            Console.WriteLine($"====== ГОРОД =====");
            Console.WriteLine($" ID |  Название  |");
            foreach (var city in DataBase.pCities)
            {
                Console.WriteLine($"{city.Id,4}|{city.CityName,12}|");
            }
        }

        private static void DeleteCity()
        {
            Console.WriteLine("Введите ID записи, который хотите удалить");
            try
            {
                int Id = Convert.ToInt32(Console.ReadLine());
                if (DataBase.GetCity(Id) == null)
                {
                    throw new Exception();
                }
                
                bool result = DataBase.DeleteCity(Id);
                string message = result ? "Запись удалена!" : "Произошла ошибка при удалении записи!";
                Console.WriteLine(message);
                
            }
            catch
            {
                Console.WriteLine("Произошла ошибка. Такого ID не существует");
            }
            
        }

        private static void AddCity()
        {
            Console.WriteLine("Введите название города: ");
            string sName = Console.ReadLine();
            bool result;
            if (sName != string.Empty)
            {
                result = DataBase.AddCity(sName);
                if (result)
                {
                    Console.WriteLine("Запись добавлена!");
                }
                else
                {
                    Console.WriteLine("Произошла какая-то ошибка!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Пустое название не может быть.");
            }
        }

        private static void ChangeCity()
        {
            Console.WriteLine("Введите ID записи, которую хотите удалить");
            try
            {
                int Id = Convert.ToInt32(Console.ReadLine());
                if (DataBase.GetCity(Id) == null)
                {
                    throw new Exception();
                }

                Console.WriteLine($"Старое название: {DataBase.GetCity(Id).CityName}");
                Console.WriteLine("Введите новое название города");
                string sNewName = Console.ReadLine();
                if (sNewName != string.Empty)
                {
                    bool result = DataBase.ChangeCity(Id, sNewName);
                    string message = result ? "Запись изменена!" : "Произошла ошибка при изменении записи!";
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("Пустое название города не может быть!");
                }
            }
            catch
            {
                Console.WriteLine("Произошла ошибка. Такого ID не существует");
            }
        }

        private static void ShowRoutes()
        {
            Console.WriteLine($"============================== МАРШРУТЫ ===========================");
            Console.WriteLine($" ID | Название |  Город(откуда)  |  Город(куда)  |  Время в пути  |"); //67
            foreach (var route in DataBase.pRoutes)
            {
                Console.WriteLine($"{route.Id,4}|{route.NameRoute,10}|{route.pCityStart.CityName,17}|{route.pCityEnd.CityName,15}|{route.TravelTime,16}|");
            } 
        }

        private static void AddRoute()
        {
            string sName;
            int CityStart;
            int CityEnd;
            TimeSpan TravelTime;

            try
            {
                Console.WriteLine("Введите название Маршрута");
                sName = Console.ReadLine();
                if (sName == string.Empty || DataBase.CheckUniqueRouteName(sName) != true)
                {
                    throw new Exception("Название маршрутов должны быть уникальными");
                }
                ShowCities();
                
                Console.WriteLine("Введите ID города(откуда)");
                CityStart = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Введите ID города(куда)");
                CityEnd = Convert.ToInt32(Console.ReadLine());

                if (DataBase.GetCity(CityStart) == null ||
                    DataBase.GetCity(CityEnd) == null || CityStart == CityEnd)
                {
                    throw new Exception("ID городов отсутствуют или ID городов совпадают");
                }

                Console.WriteLine("Введите время в пути (формат: часы:минуты:секунды)");
                TravelTime = TimeSpan.Parse(Console.ReadLine());

                bool result = DataBase.AddRoute(sName, CityStart, CityEnd, TravelTime);
                string message = result ? "Запись добавлена!" : "Произошла ошибка при добавлении записи!";
                Console.WriteLine(message);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Произошла ошибка: {e.Message}");
            }
        }

        private static void ChangeRoute()
        {
            int Id;
            string sName;
            int CityStart;
            int CityEnd;
            TimeSpan TravelTime;

            try
            {
                Console.WriteLine("Введите ID записи, которую хотите изменить");
                Id = Convert.ToInt32(Console.ReadLine());
                if (DataBase.GetRoute(Id) == null)
                {
                    throw new Exception("Записи с таким ID отсутствует");
                }

                Console.WriteLine("Введите новое название маршрута: ");
                sName = Console.ReadLine();
                if (sName == string.Empty)
                {
                    throw new Exception("Название маршрута не может быть пустым.");
                }

                ShowCities();

                Console.WriteLine("Введите ID города(откуда)");
                CityStart = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите ID города(куда)");
                CityEnd = Convert.ToInt32(Console.ReadLine());

                if (DataBase.GetCity(CityStart) == null ||
                    DataBase.GetCity(CityEnd) == null || CityStart == CityEnd)
                {
                    throw new Exception("ID городов отсутствуют или ID городов совпадают");
                }

                Console.WriteLine("Введите время в пути (формат: часы:минуты:секунды)");
                TravelTime = TimeSpan.Parse(Console.ReadLine());

                bool result = DataBase.ChangeRoute(Id, sName, CityStart, CityEnd, TravelTime);
                string message = result ? "Запись изменена!" : "Произошла ошибка при изменении записи!";
                Console.WriteLine(message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка: {e.Message}");
            }
        }

        private static void DeleteRoute()
        {
            Console.WriteLine("Введите ID записи, который хотите удалить");
            try
            {
                int Id = Convert.ToInt32(Console.ReadLine());
                if (DataBase.GetRoute(Id) == null)
                {
                    throw new Exception();
                }

                bool result = DataBase.DeleteRoute(Id);
                string message = result ? "Запись удалена!" : "Произошла ошибка при удалении записи!";
                Console.WriteLine(message);

            }
            catch
            {
                Console.WriteLine("Произошла ошибка. Такого ID не существует");
            }

        }
    }
}
