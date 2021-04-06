using System;
using System.Collections.Generic;
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
                return db.Cities.Where(x => x.Id == IdCity).FirstOrDefault();
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

        public static bool CheckHaveCity(string CityName)
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
        #endregion

        #region ModerationRoute

        public static List<Models.Route> GetRoutes()
        {
            using (DataContext db = new DataContext())
            {
                var Routes = db.Routes.Where(x => x.IsDelete == false).ToList();
                return Routes;
            }
        }

        public static Models.Route GetRoute(int IdRoute)
        {
            using (DataContext db = new DataContext())
            {
                var Route = db.Routes.Where(x => x.Id == IdRoute).FirstOrDefault();
                return Route;
            }
        }

        #endregion

        #region ModerationTableRecords



        #endregion
    }
}
