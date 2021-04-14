using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using TableBusConsole.Models;

namespace TableBusConsole
{
    static class GenerateRecords
    {
        private const int LengthRecords = 10;
        public static void Generate()
        {
            CreateCities();
            CreateRoute();
            CreateTable();
            CreateAccount();
        }

        private static void CreateCities()
        {
            for (int i = 1; i < LengthRecords + 1; i++)
            {
                DataContext.Cities.Add(new City($"test_{i}"));
            }
        }

        private static void CreateRoute()
        {
            Random rn = new Random();
            for (int i = 1; i < LengthRecords + 1; i++)
            {
                int CityStartId;
                int CityEndId;
                do
                {
                    CityStartId = rn.Next(1, LengthRecords);
                    CityEndId = rn.Next(1, LengthRecords);
                } while (CityStartId == CityEndId);
                

                /*int CityStartId = Cities.Where(x => x.Id == rn.Next(1, LengthRecords - 1)).FirstOrDefault().Id;
                int CityEndId = Cities.Where(x => x.Id == rn.Next(1, LengthRecords - 1)).FirstOrDefault().Id;*/
                Route route = new Route($"test_{i}", CityStartId, CityEndId, 
                    750.00, new TimeSpan(rn.Next(1, 23), rn.Next(1, 59), rn.Next(1, 59)));
                DataContext.Routes.Add(route);
            }
        }

        private static void CreateTable()
        {
            Random rn = new Random();
            for (int i = 1; i < LengthRecords + 1; i++)
            {
                DateTime dateTimeStart = new DateTime(2021, rn.Next(1, 10), rn.Next(1, 25), rn.Next(1, 23),
                    rn.Next(1, 59), rn.Next(1, 59));
                int IdRoute = rn.Next(1, LengthRecords);
                Route route = DataContext.Routes.Find(x => x.Id == IdRoute);
                Table table = new Table(dateTimeStart, dateTimeStart.Add(route.TravelTime), rn.Next(10, 30), 
                    rn.Next(20, 150), route.Id);
                DataContext.Tables.Add(table);
            }
        }

        private static void CreateAccount()
        {
            User user1 = new User {Id = 1, Login = "user1", Money = 500, IsAdmin = false};
            User user2 = new User { Id = 2, Login = "user2", Money = 500, IsAdmin = false };
            User user3 = new User { Id = 3, Login = "user3", Money = 500, IsAdmin = false };
            User admin = new User { Id = 4, Login = "admin", Money = 1000, IsAdmin = true };
            DataContext.Users.AddRange(new List<User>{ user1, user2, user3, admin });
        }
    }
}
