using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{

    // Дан размер массива и сам целочисленный упорядоченный по возрастанию массив.
    // Найти количество различных чисел в нем. (Пример: Дано 3 2 2 2 То результатом будет 1)
    public static class Task_1
    {
        public static void Start()
        {

            #region FirstSolutuin | Already have elements array

            // O(n) - Линейная сложность

            /*int[] arrayInts = new int[] { 1, 1, 1, 1, 2, 2, 2, 3, 4, 4, 5, 5, 6, 7, 8, 8, 8, 10 };

            int count = 0;
            for (int i = 1; i < arrayInts.Length - 1; i++)
            {
                if (arrayInts[i - 1] != arrayInts[i] && arrayInts[i] != arrayInts[i + 1])
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во: {count}");
            Console.WriteLine($"{arrayInts.ToString()}");
            Console.WriteLine($"Press the key...");
            Console.ReadKey();*/

            #endregion

            #region SecondSolution | Input elements array

            Console.WriteLine("Введите размерность массива: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] arrayInts = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Введите №{i + 1} элемент массива:");
                arrayInts[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arrayInts);

            int count = 0;
            for (int i = 1; i < arrayInts.Length - 1; i++)
            {
                if (arrayInts[i - 1] != arrayInts[i] && arrayInts[i] != arrayInts[i + 1])
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во: {count}");
            Console.WriteLine($"Press the key...");
            Console.ReadKey();

            #endregion
        }
    }
}
