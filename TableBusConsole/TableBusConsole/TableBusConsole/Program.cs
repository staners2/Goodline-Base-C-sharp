using System;
using TableBusConsole.Controller;

namespace TableBusConsole
{
    class Program
    {
        private static string[] Menu =
        {
            "1. Войти в аккаунт",
            "2. Выйти"
        };
        static void Main(string[] args)
        {
            GenerateRecords.Generate();
            bool IsExit = false;
            do
            {
                int iNumberPick;
                Console.Clear();
                Console.WriteLine("====================");
                foreach (var elem in Menu)
                {
                    Console.WriteLine($"{elem}");
                }
                Console.WriteLine("====================");

                if (!int.TryParse(Console.ReadLine(), out iNumberPick))
                {
                    continue;
                }

                Console.Clear();

                switch (iNumberPick)
                {
                    case 1:
                        AccountController.EnterAccount();
                        break;
                    case 2:
                        IsExit = true;
                        break;
                }
            } while (!IsExit);
            Console.WriteLine("=> Вы покинули приложение <=");
            Console.ReadKey();
        }
    }
}
