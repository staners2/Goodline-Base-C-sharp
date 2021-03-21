using System;
using Microsoft.VisualBasic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int iNumberPick;
                Console.Clear();
                Console.WriteLine("1. Задача 1 (Найти количество различных чисел в массиве)\n" +
                                  "2. Задача 2 (Вывести, симметрична ли матрица относительно главной диагонали?)\n" +
                                  "3. Задача 3 (Вывести цифры по спирали)\n" +
                                  "4. Выход");
                if (!int.TryParse(Console.ReadLine(), out iNumberPick))
                {
                    continue;
                }

                Console.Clear();

                switch (iNumberPick)
                {
                    case 1:
                        Task_1.Start();
                        break;
                    case 2:
                        Task_2.Start();
                        break;
                    case 3:
                        Task_3.Start();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Неверный пункт меню!");
                        break;
                }
            } while (true);
        }
    }
}
