using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.IO;
using System.Text;
using TableBusConsole.Models;

namespace TableBusConsole
{
    public static class DataContext
    {
        public static char cDelimiter = '&';

        public static string PathFolder = "DataBase";
        public static string PathCityFile = "DataBase\\City.txt";
        public static string PathRouteFile = "DataBase\\Route.txt";
        public static string PathTableFile = "DataBase\\Table.txt";
        public static string PathRecordFlightFile = "DataBase\\RecordFlight.txt";
        public static string PathUserFile = "DataBase\\User.txt";

        public static List<City> Cities { get; set; } = new List<City>();
        public static List<Route> Routes { get; set; } = new List<Route>();
        public static List<Table> Tables { get; set; } = new List<Table>();
        public static List<User> Users { get; set; } = new List<User>();
        public static List<RecordFlight> RecordFlights { get; set; } = new List<RecordFlight>();

        public static bool CheckExistsDataBase()
        {
            if (Directory.Exists(PathFolder))
            {
                return true;
            }
            return false;
        }

        public static void CreateDataBase()
        {
            Directory.CreateDirectory(PathFolder);
            using (File.Create(PathCityFile))
            using (File.Create(PathRouteFile))
            using (File.Create(PathTableFile))
            using (File.Create(PathRecordFlightFile))
            using (File.Create(PathUserFile))

            GenerateRecords.Generate();
        }

        public static void LoadData()
        {
            // Извлечение информации из списка городов
            using (StreamReader pReader = new StreamReader(PathCityFile))
            {
                string sLine;
                while ((sLine = pReader.ReadLine()) != null)
                {
                    string[] Parse = sLine.Split(cDelimiter);
                    City pCity = new City(Convert.ToInt32(Parse[0]), Parse[1]);
                    Cities.Add(pCity);
                }
            }

            // Извлечение информации из списка маршрутов
            using (StreamReader pReader = new StreamReader(PathRouteFile))
            {
                string sLine;
                while ((sLine = pReader.ReadLine()) != null)
                {
                    string[] Parse = sLine.Split(cDelimiter);
                    Route pRoute = new Route(Convert.ToInt32(Parse[0]), Parse[1],
                        Convert.ToInt32(Parse[2]), Convert.ToInt32(Parse[3]),
                    Convert.ToDouble(Parse[4]), TimeSpan.Parse(Parse[5]));
                        Routes.Add(pRoute);
                }
            }

            // Извлечение информации из списка Расписания
            using (StreamReader pReader = new StreamReader(PathTableFile))
            {
                string sLine;
                while ((sLine = pReader.ReadLine()) != null)
                {
                    string[] Parse = sLine.Split(cDelimiter);
                    Table pTable = new Table(Convert.ToInt32(Parse[0]), DateTime.Parse(Parse[1]),
                        DateTime.Parse(Parse[2]),Convert.ToInt32(Parse[3]), Convert.ToInt32(Parse[4]),
                        Convert.ToInt32(Parse[5]), Convert.ToInt32(Parse[6]));
                    Tables.Add(pTable);
                }
            }

            // Извлечение информации из списка Пользователей
            using (StreamReader pReader = new StreamReader(PathUserFile))
            {
                string sLine;
                while ((sLine = pReader.ReadLine()) != null)
                {
                    string[] Parse = sLine.Split(cDelimiter);
                    User pUser = new User(Convert.ToInt32(Parse[0]), Parse[1], Convert.ToInt32(Parse[2]), 
                        Convert.ToBoolean(Parse[3]));
                    Users.Add(pUser);
                }
            }

            // Извлечение информации из списка Приобретенных билетов
            using (StreamReader pReader = new StreamReader(PathRecordFlightFile))
            {
                string sLine;
                while ((sLine = pReader.ReadLine()) != null)
                {
                    string[] Parse = sLine.Split(cDelimiter);
                    RecordFlight pRecordFlight = new RecordFlight(Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1]),
                        Convert.ToInt32(Parse[2]));
                    RecordFlights.Add(pRecordFlight);
                }
            }
        }

        public static void SaveData()
        {
            Directory.CreateDirectory(PathFolder);
            using (File.Create(PathCityFile));
            using (File.Create(PathRouteFile));
            using (File.Create(PathTableFile));
            using (File.Create(PathRecordFlightFile));
            using (File.Create(PathUserFile));

                // Сохранение инфрмации о городах
            string tempCityFile = $"{PathFolder}\\TempCity.txt";
            using (var sw = new StreamWriter(tempCityFile))
            {
                foreach (var city in Cities)
                {
                    sw.WriteLine($"{city.Id}{cDelimiter}{city.CityName}");
                }
            }
            File.Delete(PathCityFile);
            File.Move(tempCityFile, PathCityFile);

            // Сохранение инфрмации о маршрутах
            string tempRouteFile = $"{PathFolder}\\TempRoute.txt";
            using (var sw = new StreamWriter(tempRouteFile))
            {
                foreach (var route in Routes)
                {
                    sw.WriteLine($"{route.Id}{cDelimiter}" +
                                 $"{route.NameRoute}{cDelimiter}" +
                                 $"{route.CityStart}{cDelimiter}" +
                                 $"{route.CityEnd}{cDelimiter}" +
                                 $"{route.Distance}{cDelimiter}" +
                                 $"{route.TravelTime}");
                }
            }
            File.Delete(PathRouteFile);
            File.Move(tempRouteFile, PathRouteFile);

            // Сохранение инфрмации о Расписании
            string tempTableFile = $"{PathFolder}\\TempTable.txt";
            using (var sw = new StreamWriter(tempTableFile))
            {
                foreach (var table in Tables)
                {
                    sw.WriteLine($"{table.Id}{cDelimiter}" +
                                 $"{table.DateTimeStart}{cDelimiter}" +
                                 $"{table.DateTimeEnd}{cDelimiter}" +
                                 $"{table.CurrentCountPassenger}{cDelimiter}" +
                                 $"{table.MaxCountPassenger}{cDelimiter}" +
                                 $"{table.Price}{cDelimiter}" +
                                 $"{table.Route.Id}");
                }
            }
            File.Delete(PathTableFile);
            File.Move(tempTableFile, PathTableFile);

            // Сохранение инфрмации о Пользователях
            string tempUserFile = $"{PathFolder}\\TempUser.txt";
            using (var sw = new StreamWriter(tempUserFile))
            {
                foreach (var user in Users)
                {
                    sw.WriteLine($"{user.Id}{cDelimiter}" +
                                 $"{user.Login}{cDelimiter}" +
                                 $"{user.Money}{cDelimiter}" +
                                 $"{user.IsAdmin}");
                }
            }
            File.Delete(PathUserFile);
            File.Move(tempUserFile, PathUserFile);

            // Сохранение инфрмации о Приобретенных билетах
            string tempRecordFlightFile = $"{PathFolder}\\TempRecordFlight.txt";
            using (var sw = new StreamWriter(tempRecordFlightFile))
            {
                foreach (var recordFlight in RecordFlights)
                {
                    sw.WriteLine($"{recordFlight.Id}{cDelimiter}" +
                                 $"{recordFlight.TableId}{cDelimiter}" +
                                 $"{recordFlight.UserId}");
                }
            }
            File.Delete(PathRecordFlightFile);
            File.Move(tempRecordFlightFile, PathRecordFlightFile);
        }
    }
}
