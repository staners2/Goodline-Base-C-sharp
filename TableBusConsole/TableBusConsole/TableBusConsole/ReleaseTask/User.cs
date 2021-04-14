using System;
using System.Collections.Generic;
using System.Text;

namespace TableBusConsole.ReleaseTask
{
    public class User
    {
        public string Name { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public User()
        { }

        public User(string Name, string Login, string Password)
        { }

        public virtual void HelloAccount()
        {
            Console.WriteLine($"Hello User {Name}");
        }
    }
}
