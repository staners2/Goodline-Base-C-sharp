using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableBusWinForms.Models;

namespace TableBusWinForms.AdminView.Moderation
{
    public static class ModerationController
    {
        #region ModerationCity

        public static List<Models.City> GetCities()
        {
            using (DataContext db = new DataContext())
            {
                List<Models.City> cities = db.Cities.Where(x => x.IsDelete == false).ToList();
                return cities;
            }
        }

        public static Models.City GetCity(int IdCity)
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
                Models.City city = new Models.City{CityName = CityName};
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
                Models.City city = db.Cities.Where(x => x.CityName == CityName && x.IsDelete == false).FirstOrDefault();
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
                    Models.City city = db.Cities.Where(x => x.Id == IdCity).FirstOrDefault();
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
                    db.Cities.Remove(city);
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

        public static List<Models.Route> GetRoutes()
        {
            using (DataContext db = new DataContext())
            {
                var Routes = db.Routes.Where(x => x.IsDelete == false).Include(x => x.City).Include(x => x.City1).ToList();
                return Routes;
            }
        }

        public static Models.Route GetRoute(int IdRoute)
        {
            using (DataContext db = new DataContext())
            {
                var Route = db.Routes.Where(x => x.Id == IdRoute && x.IsDelete == false).Include(x => x.City).Include(x => x.City1).FirstOrDefault();
                return Route;
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
            using (DataContext db =new DataContext())
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
                var Route = new Models.Route{NameRoute = NameRoute, CityStart = CityStartId, CityEnd = CityEndId, 
                    Distance = Distance, TravelTime = TravelTime};
                try
                {
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

        public static TimeSpan ConvertDistanceTimeTravel(double Distance)
        {
            double AvgSpeed = 14;
            double distance = Distance * 1000;
            int second = (int)(distance / AvgSpeed);
            var time = TimeSpan.FromSeconds(second);

            return time;
        }

        public static bool ChangeRoute(int IdRoute, string NameRoute, int CityStartId, int CityEndId,
            double Distance, TimeSpan TravelTime)
        {
            using (DataContext db = new DataContext())
            {
                var Route = db.Routes.Find(IdRoute);

                Route.NameRoute = NameRoute;
                Route.CityStart = CityStartId;
                Route.CityEnd = CityEndId;
                Route.Distance = Distance;
                Route.TravelTime = TravelTime;
                
                try
                {
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
                var Route = db.Routes.Find(IdRoute);

                try
                {
                    db.Routes.Remove(Route);
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

        #endregion
    }
}
