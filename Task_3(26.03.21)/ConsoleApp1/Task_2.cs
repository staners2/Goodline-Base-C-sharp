using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public static class Task_2
    {

        static private string[] Menu =
        {
            "1. Просмотр всех записей",
            "2. Добавление записи",
            "3. Удаление записи(по короткому описанию)",
            "4. Поиск записи(по короткому описанию)",
            "5. Выход"
        };

        

        public static void Start()
        {

             Dictionary<string, string> dictionaryFormats = new Dictionary<string, string>()
                {
                    {"PNG","portable network graphics"},
                    {"SWF","ShockWare Flash"},
                    {"GIF","Graphics Interchange Format"},
                    {"TIF","Tagged Image File Format"},
                    {"PSD","Photo Shop Data"},
                };
             string shortName;
             string fullName;
             bool Flag = true;
            do
            {
                ShowMenu();

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                    {
                        Console.WriteLine();
                        foreach (var elem in dictionaryFormats)
                        {
                            Console.WriteLine($"{elem.Key, 5} | {elem.Value}");
                        }
                    }
                        Console.WriteLine("Press to key...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    {
                        Console.WriteLine("\nВведите короткое название расширения для добавления:");
                        shortName = Console.ReadLine();
                        Console.WriteLine("Введите полное название расширения для добавления:");
                        fullName = Console.ReadLine();
                        if (shortName != string.Empty && fullName != string.Empty)
                        {
                            AddElement(dictionaryFormats, shortName, fullName);
                        }
                    }
                        Console.WriteLine("Press to key...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        {
                        Console.WriteLine("\nВведите короткое название расширения, которое хотите удалить:");
                        shortName = Console.ReadLine();
                        if (shortName != string.Empty)
                        {
                            if (!RemoveElement(dictionaryFormats, shortName))
                                Console.WriteLine("Произошла ошибка. Данный объект не найден!");
                        }
                    }
                        Console.WriteLine("Press to key...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        {
                        Console.WriteLine("\nВведите короткое название по которому хотите найти:");
                        shortName = Console.ReadLine();
                        if (shortName != string.Empty)
                        {
                            if (!dictionaryFormats.ContainsKey(shortName))
                            {
                                Console.WriteLine("Произошла ошибка. Данный объект не найден!");
                            }
                            else
                            {
                                var elem = dictionaryFormats.Where(x => x.Key == shortName).FirstOrDefault();
                                Console.WriteLine($"Краткое  наименование: {elem.Key} | Полное наименование: {elem.Value}");
                            }
                        }
                    }
                        Console.WriteLine("Press to key...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Flag = false;
                        break;
                }
            } while (Flag);
        }

        private static void ShowMenu()
        {
            Console.Clear();
            foreach (var str in Menu)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }

        // Добавление элемента
        private static bool AddElement(Dictionary<string, string> dictionaryFormats, string shortName, string fullName)
        {
            if (!dictionaryFormats.ContainsKey(shortName))
            {
                dictionaryFormats.Add(shortName, fullName);
                return true;
            }

            return false;

        }

        // Удаление элемента по ключу(короткому описанию)
        private static bool RemoveElement(Dictionary<string, string> dictionaryFormats, string shortName)
        {
            if (dictionaryFormats.ContainsKey(shortName))
            {
                dictionaryFormats.Remove(shortName);
                return true;
            }

            return false;
        }
    }
}
