using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Task2
    {

        // Задача 2. Посчитать расстояние между 2 координатами
        public static void Start()
        {
            int[] LastPosition = new int[] {0, 0};
            string sResult = string.Empty;
            List<char> lListLetter = new List<char>();

            while (lListLetter.Count < 10)
            {
                Console.WriteLine("Введите одно из 4 направлений(С|Ю|З|В): ");
                char letter = Char.Parse(Console.ReadLine().ToLower());
                switch (letter)
                {
                    case 'с':
                        LastPosition[0] += 1;
                        break;
                    case 'ю':
                        LastPosition[0] -= 1;
                        break;
                    case 'з':
                        LastPosition[1] -= 1;
                        break;
                    case 'в':
                        LastPosition[1] += 1;
                        break;
                    default:
                        continue;
                }
                lListLetter.Add(letter);
            }

            Console.Clear();
            double dResult = Math.Sqrt(Math.Pow(LastPosition[0], 2) + Math.Pow(LastPosition[1], 2));

            sResult =
                $"Исходная позиция: [0,0]\nКонечная точка: [{LastPosition[0]},{LastPosition[1]}]\nРасстояние: {Math.Round(dResult, 2)}";
            Console.WriteLine(sResult);

            Console.WriteLine("Для продолжения нажмите кнопку...");
            Console.ReadKey();
        }
    }
}
