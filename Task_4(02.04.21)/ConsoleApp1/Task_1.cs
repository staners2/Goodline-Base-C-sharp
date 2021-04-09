using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    public static class Task_1
    {
        private static void ShowListNumber(List<int> lNumbers)
        {
            for (int i = 0; i < lNumbers.Count; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{lNumbers[i],4}");
            }
            Console.WriteLine();
        }

        private static List<int> GenerateRandomNumbers(int Count)
        {
            Random rn = new Random();
            List<int> lListNumbers = Enumerable.Range(0, Count)
                .Select(x => x = rn.Next(0, 26)).ToList();
            return lListNumbers;
        }

        public static void Start()
        {
            Task1();
            Task2();
            Task3();
        }

        private static void Task1()
        {
            // Вывод Максимального и Минимального
            Console.WriteLine("Задание_1");
            Console.WriteLine("Вывод Максимального и Минимального значения:");
            List<int> lNumbers = GenerateRandomNumbers(15);
            ShowListNumber(lNumbers);
            int Max = lNumbers.OrderBy(x => x).Last();
            int Min = lNumbers.OrderByDescending(x => x).Last();
            Console.WriteLine($"Max: {Max} | Min: {Min}");
            Console.WriteLine("Press to key...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Task2()
        {
            // Вывод уникальных 
            Console.WriteLine("Задание_2"); 
            List<int> lNumbers = GenerateRandomNumbers(20);
            ShowListNumber(lNumbers);
            List<int> lDistinctNumbers = lNumbers.Distinct().ToList();
            int iCount = lNumbers.Distinct().Count();
            Console.WriteLine("Уникальные числа:");
            ShowListNumber(lDistinctNumbers);
            Console.WriteLine($"Distinct: {iCount} numbers");
            Console.WriteLine("Press to key...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Task3()
        {
            // от 10 до 20, вывести без повторений, в порядке убывания
            Console.WriteLine("Задание_3");
            List<int> lNumbers = GenerateRandomNumbers(50);
            ShowListNumber(lNumbers);
            Console.WriteLine("Уникальные числа:");
            List<int> lNoRepeatNumbers = lNumbers.Where(x => x >= 10 && x <= 20).Distinct().OrderByDescending(x => x).ToList();
            ShowListNumber(lNoRepeatNumbers);
            Console.WriteLine("Press to key...");
            Console.ReadKey();
        }
}
}
