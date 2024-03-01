using System;
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
            bool error = false;

            do
            {
                try
                {
                    Console.Write("Введите имя: ");
                    person.FirstName = Console.ReadLine();
                    error = false;
                }
                catch (Exception ex)
                {
                    error = true;
                    Console.WriteLine(ex.Message);
                }
            }
            while (error);

            do
            {
                try
                {
                    Console.Write("Введите фамилию: ");
                    person.LastName = Console.ReadLine();
                    error = false;
                }
                catch (Exception ex)
                {
                    error = true;
                    Console.WriteLine(ex.Message);
                }
            }
            while (error);

            do
            {
                try
                {
                    Console.Write("Введите возраст: ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    error = false;
                }
                catch (FormatException)
                {
                    error = true;
                    Console.WriteLine("Возраст не может содержать символов");
                }
                catch (ArgumentException ex)
                {
                    error = true;
                    Console.WriteLine(ex.Message);
                }
            }
            while (error);

            do
            {
                try
                {
                    Console.Write("Введите пол (1 - мужской; 0 - женский): ");
                    int genderFromConsole = 
                        Convert.ToInt32(Console.ReadLine());

                    switch (genderFromConsole)
                    {
                        case 1:
                            person.Gender = Gender.Male;
                            error = false;
                            break;

                        case 0:
                            person.Gender = Gender.Female;
                            error = false;
                            break;

                        default:
                            error = true;
                            throw new ArgumentException("Некорректный ввод." +
                                " Введите 0 или 1.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод. Повторите ввод.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (error);

            return person;
        }

        /// <summary>
        /// Выводит информацию о списке персон в консоль.
        /// </summary>
        /// <param name="personList">Список персон.</param>
        private static void PrintList(PersonList personList)
        {
            string listInfo = personList.GetListInfo();
            Console.WriteLine(listInfo);
        }

        /// <summary>
        /// Выводит в консоль длину списка персон.
        /// </summary>
        /// <param name="personList">Список персон.</param>
        public static void PrintListLength(PersonList personList)
        {
            Console.WriteLine($"Длина списка: {personList.GetListLength()}");
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

            Person duplicatePerson = firstList.GetElementByIndex(index);

            firstList.ClearListByIndex(index);

            PrintList(firstList);
            PrintList(secondList);

            Console.ReadKey();

            Console.WriteLine(" Шаг 5: Очистка второго списка\n");

            secondList.ClearAll();

            Console.WriteLine("\nСписки после очистки:");
            PrintList(firstList);
            PrintList(secondList);

            Console.ReadKey();

            Person randomPerson = Person.GetRandomPerson();
            string randomPersonInfo = randomPerson.GetPersonInfo();
            PrintPerson(randomPersonInfo);

            Console.ReadKey();

            Person personFromConsole = ReadPersonFromConsole();
            string personFromConsoleInfo = 
                personFromConsole?.GetPersonInfo()?? "Ввод отменен.";

            PrintPerson(personFromConsoleInfo);

            Console.ReadKey();
        }
    }
}