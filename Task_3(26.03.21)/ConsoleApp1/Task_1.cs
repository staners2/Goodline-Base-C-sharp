using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    public static class Task_1
    {
        public static void Start()
        {
            int AllTime;
            bool result;
            // TODO Need Fix condition
            Console.WriteLine("Введите кол-во минут: ");
            do
            {
                result = int.TryParse(Console.ReadLine(), out AllTime);
            } while (!result || AllTime <= 0);

            int CountClient;
            Console.WriteLine("Введите кол-во заказчиков: ");
            do
            {
                result = int.TryParse(Console.ReadLine(), out CountClient);
            } while (!result || CountClient <= 0);

            Console.WriteLine("Введите время требуемое на обслуживание клиентов:");
            Queue<int> NeededTimeQueue = new Queue<int>();
            do
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out int vResult) && vResult > 0)
                    NeededTimeQueue.Enqueue(vResult);
            } while (NeededTimeQueue.Count != CountClient);

            do
            {
                AllTime = AllTime - NeededTimeQueue.Dequeue();
                if (NeededTimeQueue.Count == 0)
                {
                    break;
                }
            }
            while (AllTime > 0);

            switch (NeededTimeQueue.Count)
            {
                case 0:
                    Console.WriteLine("Все клиенты были обслужены.");
                    Console.WriteLine("Press to key ...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine($"Клиенты в кол-ве {NeededTimeQueue.Count} человек не были обслужены.");
                    Console.WriteLine("Press to key ...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
