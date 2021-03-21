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
            // O(n) - Линейная сложность

            int[] arrayInts = new int[] { 1, 1, 1, 1, 2, 2, 2, 3, 4, 4, 5, 5, 6, 7, 8, 8, 8, 10};
            
            int count = 0;
            for (int i = 1; i < arrayInts.Length-1; i++)
            {
                if (arrayInts[i-1] != arrayInts[i] && arrayInts[i] != arrayInts[i + 1])
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во: {count}");
            Console.WriteLine($"Press the key...");
            Console.ReadKey();
        }
    }
}
