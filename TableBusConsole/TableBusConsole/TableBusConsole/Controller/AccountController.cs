using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableBusConsole.Models;

namespace TableBusConsole
{
    public static class AccountController
    {
        public static User User { get; set; }
        public static void EnterAccount()
        {
            bool IsHaveAccount = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите логин: ");
                string sInputLogin = Console.ReadLine();
                if (DataContext.Users.Where(x => x.Login == sInputLogin).FirstOrDefault() != null)
                {
                    IsHaveAccount = true;
                    User = DataContext.Users.Where(x => x.Login == sInputLogin).FirstOrDefault();
                }
            } while (!IsHaveAccount);

            MenuController.Start();
        }

        public static void ShowUserInfo()
        {
            User user = AccountController.User;
            int CountRecords = FlightController.GetRecordFlightThisAccount(AccountController.User.Id);
            Console.WriteLine("===== ИНФОРМАЦИЯ ОБ АККАУНТЕ =====");
            string IsAdmin = user.IsAdmin == true ? "Admin" : "User";
            Console.WriteLine($"ID: {user.Id}\nLogin: {user.Login}\nMoney: {user.Money}\nДолжность: {IsAdmin}");
            Console.WriteLine("=================================");
        }
    }
}
