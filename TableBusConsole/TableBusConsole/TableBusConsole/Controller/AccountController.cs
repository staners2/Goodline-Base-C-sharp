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
            Console.Clear();
            Console.WriteLine("Введите логин: ");
            string sInputLogin = Console.ReadLine();
            if (DataContext.Users.Where(x => x.Login == sInputLogin).FirstOrDefault() != null)
            {
                User = DataContext.Users.Where(x => x.Login == sInputLogin).FirstOrDefault();
                MenuController.Start();
            }
            else
            {
                Console.WriteLine("Ошибка! Данного пользователя не существует");
                Console.ReadKey();
            }
        }

        public static void GiveMoneyForAccount(int IdAccount)
        {
            Console.WriteLine("====== ПОПОЛНЕНИЕ БАЛАНСА =======");
            int iMoney = 200;
            Console.WriteLine("=> Проверка на робота <=");
            string sCode = Convert.ToString(new Random().Next(10000, 99999));
            Console.WriteLine($"Введите код: {sCode}");
            string sInputCode = Console.ReadLine();
            if (sCode == sInputCode)
            {
                User user = DataContext.Users.Where(x => x.Id == IdAccount).FirstOrDefault();
                user.Money += iMoney;
                Console.WriteLine($"Баланс пополнен на {iMoney}rub\nБаланс составляет: {user.Money}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"=> ПРОВЕРКА НА БОТА НЕ ПРОЙДЕНА <=");
                Console.ReadKey();
            }

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
