using System;
using System.Collections.Generic;
using Model;

namespace Model
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class ConsoleLoader
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        private static void Main(string[] args)
        {
            while (true) 
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine($"Нажмите 1 - если хотите начать расчет," +
                           $"\nНажмите 2 - если хотите выйти из программы");

                bool isParsed = short.TryParse(Console.ReadLine(),
                    out short action);

                if(!isParsed) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("некорректный ввод!");
                }

                switch (action) 
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        ReadFigureFromConsole.AddFigure();
                        break;

                    case 2:
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите 1 или 2");
                        break;
                }
            }
        }
    }
}