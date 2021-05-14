using LibraryController.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryController
{
    public static class Controller
    {
        public const int PriceOneScore = 10;

        #region Форма регистрации/авторизации
        // Проверка на наличие аккаунта в базе данных
        public static bool CheckUserExists(string Login)
        {
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
                User User = new User() { Login = Login };
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
                                x.Route.City.CityName == CityStart && x.Route.City1.CityName == CityEnd)
                    .ToList();
                return TableRecords;
            }
        }

        public static List<Table> GetTableRecords(DateTime dateTime)
        {
            using (DataContext db = new DataContext())
            {
                var selectDate = dateTime.Date;
                List<Table> TableRecords = db.Tables
                    .Include(x => x.Route.City)
                    .Include(x => x.Route.City1)
                    .Where(x => DbFunctions.TruncateTime(x.DateTimeStart) == selectDate && x.IsDelete == false)
                    .ToList();
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

        public static int GetAmountFreePlaces(int IdTable)
        {
            using (DataContext db = new DataContext())
            {
                var table = db.Tables.Find(IdTable);
                return table.MaxCountPassenger - table.CurrentCountPassenger;
            }
        }

        public static int GetMoneyForUser(int IdAccount)
        {
            using (DataContext db = new DataContext())
            {
                return db.Users.Find(IdAccount).Money;
            }
        }

        public static List<City> GetCities()
        {
            using (DataContext db = new DataContext())
            {
                List<City> cities = db.Cities.Where(x => x.IsDelete == false).ToList();
                return cities;
            }
        }

        public static bool BuyTicketForUser(int IdAccount, int IdTable)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    db.RecordFlights.Add(new RecordFlight { TableId = IdTable, UserId = IdAccount });
                    var table = db.Tables.Find(IdTable);
                    table.CurrentCountPassenger++;
                    var user = db.Users.Find(IdAccount);
                    user.Money = user.Money - table.Price;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
        }

        public static bool ReturnTicket(int IdRecordFlights)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    var pRecordFlight = db.RecordFlights.Find(IdRecordFlights);
                    var pUser = db.Users.Find(pRecordFlight.UserId);
                    var pTable = db.Tables.Find(pRecordFlight.TableId);
                    pUser.Money += pTable.Price;
                    pTable.CurrentCountPassenger--;
                    db.RecordFlights.Remove(pRecordFlight);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static List<RecordFlight> GetFlightRecords(int IdAccount)
        {
            using (DataContext db = new DataContext())
            {
                var pList = db.RecordFlights
                    .Where(x => x.UserId == IdAccount)
                    .Include(x => x.Table)
                    .Include(x => x.Table.Route)
                    .Include(x => x.Table.Route.City)
                    .Include(x => x.Table.Route.City1).ToList();

                return pList;
            }
        }

        public static bool GiveMoneyForAccount(int IdAccount, int Score)
        {
            int TotalMoney = PriceOneScore * Score;
            using (DataContext db = new DataContext())
            {
                try
                {
                    User pUser = db.Users.Find(IdAccount);
                    pUser.Money += TotalMoney;
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
