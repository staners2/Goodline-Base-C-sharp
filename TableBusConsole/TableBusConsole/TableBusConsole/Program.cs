using System;

namespace TableBusConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateRecords.Generate();
            AccountController.EnterAccount();
            Console.WriteLine("=> Вы покинули приложение <=");
            Console.ReadKey();
        }
    }
}
