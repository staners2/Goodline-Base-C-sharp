using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Library.Models;

namespace Library
{
    public static class DataBase
    {
        public static string PathFolder = "DataBase";
        public static string PathCityFile = "DataBase\\City.txt";
        public static string PathRouteFile = "DataBase\\Route.txt";

        public static char cDelimiter = '&';

        public static List<City> pCities { get; set; } = new List<City>();
        public static List<Route> pRoutes { get; set; } = new List<Route>();

        public static void Start()
        {
            if (Directory.Exists(PathFolder))
            {
                if (!File.Exists(PathCityFile) || !File.Exists(PathRouteFile))
                {
                    switch (File.Exists(PathCityFile))
                    {
                        case true:
                            using (File.Create(PathRouteFile));
                            break;
                        case false:
                            using (File.Create(PathCityFile));
                            break;
                    }
                }
            }
            else
            {
                CreateData();
            }
            LoadData();
        }

        public static void CreateData()
        {
            Directory.CreateDirectory(PathFolder);
            using (File.Create(PathCityFile));
            using (File.Create(PathRouteFile));
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
                    pCities.Add(pCity);
                }
            }

            // Извлечение информации из списка маршрутов
            using (StreamReader pReader = new StreamReader(PathRouteFile))
            {
                string sLine;
                while ((sLine = pReader.ReadLine()) != null)
                {
                    string[] Parse = sLine.Split(cDelimiter);
                    Route pRoute = new Route(Convert.ToInt32(Parse[0]), Parse[1], Convert.ToInt32(Parse[2]), 
                        Convert.ToInt32(Parse[3]), TimeSpan.Parse(Parse[4]));
                    pRoutes.Add(pRoute);
                }
            }
        }

        public static int GetCityLastId()
        {
            using (StreamReader pReader = new StreamReader(PathCityFile))
            {
                string sLine;
                try
                { 
                    sLine = File.ReadLines(PathCityFile).Last();
                }
                catch
                {
                    return 0;
                }
                
                string[] Parse = sLine.Split(cDelimiter);
                int Id = Convert.ToInt32(Parse[0]);
                return Id;
            }
        }

        public static int GetRouteLastId()
        {
            using (StreamReader pReader = new StreamReader(PathRouteFile))
            {
                string sLine;
                try
                {
                    sLine = File.ReadLines(PathRouteFile).Last();
                }
                catch
                {
                    return 0;
                }
                string[] Parse = sLine.Split(cDelimiter);
                int Id = Convert.ToInt32(Parse[0]);
                return Id;
            }
        }

        public static Route GetRoute(int Id)
        {
            using (StreamReader pReader = new StreamReader(PathRouteFile))
            {
                string sLine;
                while ((sLine = pReader.ReadLine()) != null)
                {
                    string[] Parse = sLine.Split(cDelimiter);
                    if (Id == Convert.ToInt32(Parse[0]))
                    {
                        Route pRoute = new Route(Convert.ToInt32(Parse[0]), Parse[1], Convert.ToInt32(Parse[2]), Convert.ToInt32(Parse[3]), TimeSpan.Parse(Parse[4]));
                        return pRoute;
                    }
                }
            }
            return null;
        }

        public static City GetCity(int Id)
        {
            using (StreamReader pReader = new StreamReader(PathCityFile))
            {
                string sLine;
                while ((sLine = pReader.ReadLine()) != null)
                {
                    string[] Parse = sLine.Split(cDelimiter);
                    if (Id == Convert.ToInt32(Parse[0]))
                    {
                        City pCity = new City(Convert.ToInt32(Parse[0]), Parse[1]);
                        return pCity;
                    }
                }
            }
            return null;
        }

        public static bool AddCity(string NameCity)
        {
            try
            {
                City pCity = new City(NameCity);
                using (StreamWriter pReader = new StreamWriter(PathCityFile, true))
                {
                    pReader.WriteLine(pCity.ToString());
                }
                pCities.Add(pCity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ChangeCity(int Id, string CityName)
        {
            try
            {
                string SearchString = DataBase.pCities.Find(x => x.Id == Id).ToString();
                string tempFile = $"{PathFolder}\\TempCity.txt";
                using (var sr = new StreamReader(PathCityFile))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != SearchString)
                            sw.WriteLine(line);
                    }
                }

                File.Delete(PathCityFile);
                File.Move(tempFile, PathCityFile);

                City pCity = DataBase.pCities.Find(x => x.Id == Id);
                pCity.CityName = CityName;
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static bool DeleteCity(int Id)
        {
            try
            {
                string SearchString = DataBase.pCities.Find(x => x.Id == Id).ToString();
                string tempFile = $"{PathFolder}\\TempCity.txt";
                using (var sr = new StreamReader(PathCityFile))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != SearchString)
                            sw.WriteLine(line);
                    }
                }

                File.Delete(PathCityFile);
                File.Move(tempFile, PathCityFile);

                City pCity = pCities.Find(x => x.Id == Id);
                pCities.Remove(pCity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddRoute(string NameRoute, int CityStart, int CityEnd, TimeSpan TravelTime)
        {
            try
            {
                Route pRoute = new Route(NameRoute, CityStart, CityEnd, TravelTime);
                using (StreamWriter pReader = new StreamWriter(PathRouteFile, true))
                {
                    pReader.WriteLine(pRoute.ToString());
                }
                pRoutes.Add(pRoute);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ChangeRoute(int Id, string NameRoute, int CityStart, int CityEnd, TimeSpan TravelTime)
        {
            try
            {
                string ChangeString = GetRoute(Id).ToString();
                string tempFile = $"{PathFolder}\\TempRoute.txt";
                using (var sr = new StreamReader(PathRouteFile))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == ChangeString)
                            sw.WriteLine(ChangeString);
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                }

                File.Delete(PathRouteFile);
                File.Move(tempFile, PathRouteFile);

                Route pRoute = GetRoute(Id);
                pRoute.NameRoute = NameRoute;
                pRoute.CityStart = CityStart;
                pRoute.CityEnd = CityEnd;
                pRoute.TravelTime = TravelTime;

                pRoute.pCityStart = GetCity(CityStart);
                pRoute.pCityEnd = GetCity(CityEnd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteRoute(int Id)
        {
            try
            {
                string SearchString = GetRoute(Id).ToString();
                string tempFile = $"{PathFolder}\\TempRoute.txt";
                using (var sr = new StreamReader(PathRouteFile))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != SearchString)
                            sw.WriteLine(line);
                    }
                }

                File.Delete(PathRouteFile);
                File.Move(tempFile, PathRouteFile);

                Route pRoute = GetRoute(Id);
                pRoutes.Remove(pRoute);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckUniqueRouteName(string sName)
        {
            using (StreamReader pReader = new StreamReader(PathRouteFile))
            {
                string sLine;
                while ((sLine = pReader.ReadLine()) != null)
                {
                    string[] Parse = sLine.Split(cDelimiter);
                    if (sName == Parse[1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
