﻿using System;
using System.Collections.Generic;
using PersonListLibrary;

namespace PersonListLab
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Выводит информацию о человеке в консоль.
        /// </summary>
        /// <param name="info">Информация о человеке.</param>
        private static void PrintPerson(string info)
        {
            Console.WriteLine(info);
        }

        /// <summary>
        /// Считывает информацию о человеке из консоли.
        /// </summary>
        /// <returns>Объект класса Person,
        /// представляющий введенного человека.</returns>
        private static Person ReadPersonFromConsole()
        {
            Person person = new Person();

            List<Action> actions = new List<Action>()
            {
                () =>
                {
                     Console.Write("Введите имя: ");
                     person.FirstName = Console.ReadLine();
                },
                () =>
                {
                     Console.Write("Введите фамилию: ");
                     person.LastName = Console.ReadLine();
                },
                () =>
                {
                     Console.Write("Введите возраст: ");
                     person.Age = Convert.ToInt32(Console.ReadLine());
                },
                () =>
                {
                     Console.Write("Введите пол " +
                         "(1 - мужской; 0 - женский): ");
                    int genderFromConsole =
                        Convert.ToInt32(Console.ReadLine());

                    switch (genderFromConsole)
                    {
                        case 1:
                            person.Gender = Gender.Male;
                            break;

                        case 0:
                            person.Gender = Gender.Female;
                            break;

                        default:
                            throw new ArgumentException("Некорректный ввод."+
                                " Введите 0 или 1.");
                    }
                }
            };

            foreach (Action action in actions)
            {
                ActionHandler(action);
            }

            return person;
        }

        /// <summary>
        /// Выводит информацию о списке персон в консоль.
        /// </summary>
        /// <param name="personList">Список персон.</param>
        private static void PrintList(PersonList personList)
        {
            string listInfo = personList.GetInfo();
            Console.WriteLine(listInfo);
        }

        /// <summary>
        /// Выводит в консоль длину списка персон.
        /// </summary>
        /// <param name="personList">Список персон.</param>
        public static void PrintLength(PersonList personList)
        {
            Console.WriteLine($"Длина списка: {personList.GetLength()}");
        }

        /// <summary>
        /// Метод обработки возможных исключений.
        /// </summary>
        /// <param name="action">Действие.</param>
        public static void ActionHandler(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }

                catch (Exception ex)
                {
                    var exceptionType = ex.GetType();
                    if (exceptionType == typeof(FormatException) ||
                        exceptionType == typeof(ArgumentOutOfRangeException) ||
                        exceptionType == typeof(ArgumentException))

                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Шаг 1: Создание двух списков персон \n");

            List<Person> personList1 = new List<Person>
            {
                new Person("Фауст", "Иоганн", 70, Gender.Male),
                new Person("Пернат", "Атанасиус", 43, Gender.Male),
                new Person("Крейн", "Иккабод", 31, Gender.Male)
            };

            List<Person> personList2 = new List<Person>
            {
                new Person("Ван-Тассел", "Катерина", 23, Gender.Female),
                new Person("Циглер", "Евгений", 24, Gender.Female),
                new Person("Рожникова", "Татьяна", 22, Gender.Female)
            };

            PersonList firstList = 
                new PersonList(personList1, "Первый список");

            PersonList secondList = 
                new PersonList(personList2, "Второй список");

            Console.ReadKey();
            Console.WriteLine("Вывод содержимого списков: \n");

            PrintList(firstList);

            PrintList(secondList);

            Console.ReadKey();

            Console.WriteLine("Шаг 2: Добавление нового человека" +
                " в первый список \n");

            firstList.AddPersonToList(new Person("Жижка", 
                "Ян", 64, Gender.Male));

            PrintList(firstList);

            Console.ReadKey();

            Console.WriteLine("Шаг 3: Копирование второго человека" +
                " из первого списка в конец второго списка \n");
            
            int index = 1;

            secondList.AddPersonToList(firstList.GetElementByIndex(index));

            PrintList(firstList);
            PrintList(secondList);

            Console.ReadKey();

            Console.WriteLine("Шаг 4: Удаление второго человека" +
                " из первого списка \n");

            firstList.ClearByIndex(index);

            PrintList(firstList);
            PrintList(secondList);

            Console.ReadKey();

            Console.WriteLine(" Шаг 5: Очистка второго списка\n");

            secondList.ClearAll();

            Console.WriteLine("\nСписки после очистки:");
            PrintList(firstList);
            PrintList(secondList);

            Console.ReadKey();

            Person randomPerson = Person.GetRandom();
            string randomPersonInfo = randomPerson.GetInfo();
            PrintPerson(randomPersonInfo);

            Console.ReadKey();

            Person personFromConsole = ReadPersonFromConsole();
            string personFromConsoleInfo = 
                personFromConsole?.GetInfo()
                    ?? "Ввод отменен.";

            PrintPerson(personFromConsoleInfo);

            Console.ReadKey();
        }
    }
}