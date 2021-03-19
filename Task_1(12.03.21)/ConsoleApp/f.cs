using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class f: IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public f(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void Dispose()
        {
            Console.WriteLine("Объект удален!");
        }
    }
}
