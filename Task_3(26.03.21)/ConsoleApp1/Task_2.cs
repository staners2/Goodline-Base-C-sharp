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
            "5. Поиск полного имени формата по вхождению символа",
            "6. Вывеси записи отсортированнные по алфавиту, по краткому наименованию",
            "7. Вывести все краткие наименования",
            "8. Выход"
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
                        ShowAllFormats(dictionaryFormats);
                        break;
                    }
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
                        else
                        {
                            Console.WriteLine("Ошибка! Поля не могут быть пустыми!");
                        }
                        Console.WriteLine("Press to key...");
                        Console.ReadKey();
                        break;
                    }

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
                        Console.WriteLine("Press to key...");
                        Console.ReadKey();
                        break;
                    }

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
                        Console.WriteLine("Press to key...");
                        Console.ReadKey();
                        break;
                    }
                        

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                    {
                        Console.WriteLine("\nВведите символ по которому будет осуществлен поиск: ");
                        char inputChar = Console.ReadKey().KeyChar;
                        var dictionary = GetFormatContainsLetter(dictionaryFormats, inputChar);
                        if (dictionary.Count == 0)
                        {
                            Console.WriteLine($"\nЗаписей с вхождением символа: [{inputChar}] не обнаружено");
                        }
                        ShowAllFormats(dictionary);
                        break;
                    }

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                    {
                        var dictionary = OrderDictionaryFormats(dictionaryFormats);
                        ShowAllFormats(dictionary);
                        break;
                    }

                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        GetShortNameList(dictionaryFormats);
                        break;

                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        Flag = false;
                        break;
                }
            } while (Flag);
        }

        private static void ShowAllFormats(Dictionary<string, string> dictionaryFormats)
        {
            Console.WriteLine();
            foreach (var elem in dictionaryFormats)
            {
                Console.WriteLine($"{elem.Key,5} | {elem.Value}");
            }
            Console.WriteLine("Press to key...");
            Console.ReadKey();
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

        #region Реализация нового функционала с использованием LINQ

        // Проверка на вхождение символа в полное название формата
        private static Dictionary<string, string> GetFormatContainsLetter(Dictionary<string, string> dictionaryFormats, char letter)
        {
            var dictionary = dictionaryFormats.Where(x => x.Value.Contains(letter)).ToDictionary(key => key.Key, value => value.Value);
            return dictionary;
        }

        // Вывод отсортированного словаря по краткому наименованию формата по алфавиту
        private static Dictionary<string, string> OrderDictionaryFormats(Dictionary<string, string> dictionaryFormats)
        {
            var dictionary = dictionaryFormats.OrderBy(x => x.Key).ToDictionary(key => key.Key, value => value.Value);
            return dictionary;
        }

        private static void GetShortNameList(Dictionary<string, string> dictionaryFormats)
        {
            var List = dictionaryFormats.Select(x => x.Key);
            Console.WriteLine();
            foreach (var elem in List)
            {
                Console.WriteLine($"{elem,5}");
            }
            Console.WriteLine("Press to key...");
            Console.ReadKey();
        }

        #endregion
    }
}
