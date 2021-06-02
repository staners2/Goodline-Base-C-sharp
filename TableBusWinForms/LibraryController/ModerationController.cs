using LibraryController.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LibraryController
{
    public static class ModerationController
    {
        #region ModerationCity

        public static List<City> GetCities()
        {
            using (DataContext db = new DataContext())
            {
                List<City> cities = db.Cities.Where(x => x.IsDelete == false).ToList();
                return cities;
            }
        }

        public static City GetCity(int IdCity)
        {
            using (DataContext db = new DataContext())
            {
                return db.Cities.Where(x => x.Id == IdCity && x.IsDelete == false).FirstOrDefault();
            }
        }

        public static bool AddCity(string CityName)
        {
            using (DataContext db = new DataContext())
            {
                City city = new City { CityName = CityName };
                try
                {
                    db.Cities.Add(city);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool IsHaveCity(string CityName)
        {
            using (DataContext db = new DataContext())
            {
                City city = db.Cities.Where(x => x.CityName == CityName && x.IsDelete == false).FirstOrDefault();
                switch (city)
                {
                    case null:
                        return false;
                    default:
                        return true;
                }
            }
        }

        public static bool ChangeCity(int IdCity, string CityName)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    City city = db.Cities.Where(x => x.Id == IdCity).FirstOrDefault();
                    city.CityName = CityName;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public static bool RemoveCity(int IdCity)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    var city = db.Cities.Where(x => x.Id == IdCity).FirstOrDefault();
                    city.IsDelete = true;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool IsHaveCity(string CityName, int IdCity)
        {
            using (DataContext db = new DataContext())
            {
                var City = db.Cities.Where(x => x.CityName == CityName && x.Id != IdCity && x.IsDelete == false).FirstOrDefault();
                switch (City)
                {
                    case null:
                        return false;
                    default:
                        return true;
                }
            }
        }

        #endregion

        #region ModerationRoute

        public static List<Route> GetRoutes()
        {
            using (DataContext db = new DataContext())
            {
                var Routes = db.Routes.Where(x => x.IsDelete == false).Include(x => x.City).Include(x => x.City1).ToList();
                return Routes;
            }
        }

        public static Route GetRoute(int IdRoute)
        {
            using (DataContext db = new DataContext())
            {
                var Route = db.Routes.Where(x => x.Id == IdRoute && x.IsDelete == false).Include(x => x.City).Include(x => x.City1).FirstOrDefault();
                return Route;
            }
        }

        public static Route GetRoute(string NameRoute)
        {
            using (DataContext db = new DataContext())
            {
                return db.Routes.Where(x => x.NameRoute == NameRoute).Include(x => x.City).Include(x => x.City1).FirstOrDefault();
            }
        }

        public static int GetCityId(string CityName)
        {
            using (DataContext db = new DataContext())
            {
                int IdCity = db.Cities.Where(x => x.CityName == CityName && x.IsDelete == false).FirstOrDefault().Id;
                return IdCity;
            }
        }

        public static bool IsHaveRoute(string NameRoute, int IdRoute)
        {
            using (DataContext db = new DataContext())
            {
                var Route = db.Routes.Where(x => x.NameRoute == NameRoute && x.Id != IdRoute && x.IsDelete == false).FirstOrDefault();
                switch (Route)
                {
                    case null:
                        return false;
                    default:
                        return true;
                }
            }
        }

        public static bool IsHaveRoute(string NameRoute)
        {
            using (DataContext db = new DataContext())
            {
                var Route = db.Routes.Where(x => x.NameRoute == NameRoute && x.IsDelete == false).FirstOrDefault();
                switch (Route)
                {
                    case null:
                        return false;
                    default:
                        return true;
                }
            }
        }

        public static bool AddRoute(string NameRoute, int CityStartId, int CityEndId,
            double Distance, TimeSpan TravelTime)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    var Route = new Route
                    {
                        NameRoute = NameRoute,
                        CityStart = CityStartId,
                        CityEnd = CityEndId,
                        Distance = Distance,
                        TravelTime = TravelTime
                    };

                    db.Routes.Add(Route);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static DateTime ConvertDistanceTimeTravel(double Distance)
        {
            double AvgSpeed = 14;
            double distance = Distance * 1000;
            int second = (int)(distance / AvgSpeed);
            var time = TimeSpan.FromSeconds(second);

            DateTime TimeTravel = new DateTime(2000, 1, 1, time.Hours, time.Minutes, time.Seconds);
            return TimeTravel;
        }

        public static bool ChangeRoute(int IdRoute, string NameRoute, int CityStartId, int CityEndId,
            double Distance, TimeSpan TravelTime)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    var Route = db.Routes.Find(IdRoute);

                    Route.NameRoute = NameRoute;
                    Route.CityStart = CityStartId;
                    Route.CityEnd = CityEndId;
                    Route.Distance = Distance;
                    Route.TravelTime = TravelTime;

                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool RemoveRoute(int IdRoute)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    var Route = db.Routes.Find(IdRoute);
                    Route.IsDelete = true;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        #endregion

        #region ModerationTableRecords

        public static List<Table> GetTableRecords()
        {
            using (DataContext db = new DataContext())
            {
                return db.Tables.Where(x => x.IsDelete == false).Include(x => x.Route)
                    .Include(x => x.Route.City).Include(x => x.Route.City1).ToList();

            }
        }

        public static Table GetTable(int IdTable)
        {
            using (DataContext db = new DataContext())
            {
                return db.Tables.Where(x => x.Id == IdTable).Include(x => x.Route).Include(x => x.Route.City).Include(x => x.Route.City1).FirstOrDefault();
            }
        }

        public static bool AddTableRecord(int RouteId, DateTime dateTimeStart, DateTime dateTimeEnd,
            int iMaxCountPassenger, int iPrice)
        {
            using (DataContext db = new DataContext())
            {

                try
                {
                    Table table = new Table
                    {
                        RouteId = RouteId,
                        DateTimeStart = dateTimeStart,
                        DateTimeEnd = dateTimeEnd,
                        CurrentCountPassenger = 0,
                        MaxCountPassenger = iMaxCountPassenger,
                        Price = iPrice
                    };
                    db.Tables.Add(table);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool ChangeTableRecord(int IdTableRecord, int RouteId, DateTime dateTimeStart, DateTime dateTimeEnd,
            int iMaxCountPassenger, int iPrice)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    var table = db.Tables.Where(x => x.Id == IdTableRecord).FirstOrDefault();
                    table.RouteId = RouteId;
                    table.MaxCountPassenger = iMaxCountPassenger;
                    table.DateTimeStart = dateTimeStart;
                    table.DateTimeEnd = dateTimeEnd;
                    table.Price = iPrice;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool RemoveTableRecord(int IdTableRecord)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    Table table = db.Tables.Where(x => x.Id == IdTableRecord).FirstOrDefault();
                    table.IsDelete = true;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        #endregion
    }
}
