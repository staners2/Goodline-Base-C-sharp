using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableBusWinForms.Models;
using System.Data.Entity;

namespace TableBusWinForms
{
    public static class Controller
    {
        #region Форма регистрации/авторизации
        // Проверка на наличие аккаунта в базе данных
        public static bool CheckUserExists(string Login)
        {
            bool Result;
            using (DataContext db = new DataContext())
            {
                User User = db.Users.Where(x => x.Login == Login).FirstOrDefault();
                if (User != null)
                {
                    return true;
                }
            }
            return false;
        }

        public static User GetUser(string Login)
        {
            using (DataContext db = new DataContext())
            {
                return db.Users.Where(x => x.Login == Login).FirstOrDefault();
            }
        }

        // Регистрация аккаунта
        public async static Task<int> RegistrationUser(string Login)
        {
            int Id;
            using (DataContext db = new DataContext())
            {
                User User = new User() {Login = Login};
                db.Users.Add(User);
                db.SaveChanges();
                Id = User.Id;
            }
            return Id;
        }
        #endregion

        #region Взаимодействие с расписанием
        public static List<Table> GetTableRecords(DateTime dateTime, string CityStart, string CityEnd)
        {
            using (DataContext db = new DataContext())
            {
                var selectDate = dateTime.Date;
                List<Table> TableRecords = db.Tables.Include(x => x.Route.City).Include(x => x.Route.City1)
                    .Where(x => DbFunctions.TruncateTime(x.DateTimeStart) == selectDate && x.IsDelete == false && 
                                x.Route.City.CityName == CityStart && x.Route.City1.CityName == CityEnd
                                && x.Route.City.IsDelete == false && x.Route.City1.IsDelete == false).ToList();
                return TableRecords;
            }
        }

        public static Table GetTable(int IdTable)
        {
            using (DataContext db = new DataContext())
            {
                return db.Tables.Where(x => x.Id == IdTable).Include(x => x.Route).Include(x => x.Route.City).Include(x => x.Route.City1).FirstOrDefault();
            }
        }

        // Проверка на свободные места на данный рейс
        public static bool CheckFreeTableRecord(int IdRecord)
        {
            using (DataContext db = new DataContext())
            {
                Table TableRecord = db.Tables.Find(IdRecord);
                switch (TableRecord.CurrentCountPassenger < TableRecord.MaxCountPassenger)
                {
                    case true:
                        return true;
                    default:
                        return false;
                }
            }
        }

        public static List<City> GetCities()
        {
            using (DataContext db = new DataContext())
            {
                List<Models.City> cities = db.Cities.Where(x => x.IsDelete == false).ToList();
                return cities;
            }
        }
        #endregion
    }
}
