using System;
using System.Collections.Generic;
using System.Text;

namespace TableBusConsole.ReleaseTask
{
    public class Admin : User
    {
        public bool IsAdmin { get; set; }
        public Admin(string Name, string Login, string Password, bool isAdmin = true)
            : base(Name, Login, Password)
        { }

        public Admin()
        { }

        public override void HelloAccount()
        {
            Console.WriteLine($"Hello Admin {Name}");
        }

    }
}
