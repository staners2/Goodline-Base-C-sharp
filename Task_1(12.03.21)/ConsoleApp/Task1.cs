using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Task1
    {
        // Задача 1. Вывести название месяца по числу месяца
        public static void Start()
        {
            int Number;

            do
            {
                Console.WriteLine("Введите номер месяца(1-12): ");
                if (int.TryParse(Console.ReadLine(), out Number) && Number >= 1 && Number <= 12) break;
                Console.Clear();
            } while (true);

            Console.WriteLine(GetNameMonth(Number));
            Console.WriteLine("Для продолжения нажмите кнопку...");
            Console.ReadKey();
        }

        public static string GetNameMonth(int Number)
        {
            string sNameMonth = new DateTime(DateTime.Now.Year, Number, 1).ToString("MMMM");
            return ($"Название месяца: {sNameMonth}");
        }
    }
}
