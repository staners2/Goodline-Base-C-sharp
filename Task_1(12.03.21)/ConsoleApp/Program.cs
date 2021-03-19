using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (f f = new f(1, "name"))
            {
                Console.WriteLine(f.Name);
            }
            
            Console.ReadKey();
            /*do
            {
                int iNumberPick;
                Console.Clear();
                Console.WriteLine("1. Задача 1 (Название месяца по его номеру)\n2. Задача 2 (Расстояние между 2 координатами)\n3. Выход");
                if (!int.TryParse(Console.ReadLine(), out iNumberPick))
                {
                    continue;
                }

                Console.Clear();

                switch (iNumberPick)
                {
                    case 1:
                        Task1.Start();
                        break;
                    case 2:
                        Task2.Start();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Неверный пункт меню!");
                        break;
                }
            } while (true);*/
        }
    }
}
