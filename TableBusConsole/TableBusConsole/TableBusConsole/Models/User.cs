using System;
using System.Collections.Generic;
using System.Text;

namespace TableBusConsole.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int Money { get; set; }
        public bool IsAdmin { get; set; }

        // Конструктор без параметров
        public User()
        {

        }

        public User(int Id, string sLogin, int iMoney, bool IsAdmin)
        {
            this.Id = Id;
            this.Login = sLogin;
            this.Money = iMoney;
            this.IsAdmin = IsAdmin;
        }
    }
}
