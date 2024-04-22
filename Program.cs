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
        private static PersonBase ReadPersonFromConsole()
        {
            PersonBase person = new Adult();

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

            PersonList personList = new PersonList("Список взрослых и детей");

            Random random = new Random();
            int numAdults = random.Next(3, 7);
            int numChildren = random.Next(3, 7);

            for (int i = 0; i < numAdults; i++)
            {
                personList.AddPersonToList(RandomPerson.GetRandomAdult());
            }

            for (int i = 0; i < numChildren; i++)
            {
                personList.AddPersonToList(RandomPerson.GetRandomChild());
            }

            Console.WriteLine(personList.GetInfo());

            var fourthPerson = personList.GetElementByIndex(3);
            Console.ForegroundColor = ConsoleColor.Red;
            //TODO: switch-cases +
            switch(fourthPerson) 
            {
                case Adult testAdult:
                    Console.WriteLine("Четвертый человек в списке - взрослый:");
                    Console.WriteLine(testAdult.CitizenGreetings());
                    break;

                case Child testChild:
                    Console.WriteLine("Четвертый человек в списке - ребенок:");
                    Console.WriteLine(testChild.ChildGreetings());
                    break;
            }
            Console.ReadKey();
        }
    }
}