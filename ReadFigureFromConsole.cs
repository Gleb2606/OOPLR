using Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Model
{
    /// <summary>
    /// Класс добавления параметров фигуры.
    /// </summary>
    public class ReadFigureFromConsole
    {
        //TODO: RSDN +
        /// <summary>
        /// Константа степени округления числа.
        /// </summary>
        public const int RoundNumber = 3;

        /// <summary>
        /// Метод проверки ввода числа.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static double CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }

            bool isParsed = double.TryParse(number,
                        out double checkNumber);

            if (!isParsed)
            {
                throw new ArgumentException("Введите число!");
            }

            return checkNumber;
        }

        /// <summary>
        /// Метод добавления парметров фигуры.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static void AddFigure()
        {
            FigureBase figure = new Circle();

            Action actionStart = new Action(() =>
            {
                Console.Write($"1 - круг,\n" +
                    $"2 - прямоугольник,\n3 - треугольник." +
                    $"\nВыберите фигуру: ");

                bool _ = int.TryParse(Console.ReadLine(), out int what);
                switch (what)
                {
                    case 1:
                    {
                        figure = new Circle();
                        break;
                    }
                    case 2:
                    {
                        figure = new Rectangle();
                        break;
                    }
                    case 3:
                    {
                        figure = new Triangle();
                        break;
                    }
                    default:
                    {
                        throw new ArgumentException
                        ("Такой фигуры не существует");
                    }
                }
            });

            var actionCircle = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите радиус круга: ");
                    Circle circle = (Circle)figure;
                    circle.Radius = CheckNumber(Console.ReadLine());

                }), "радиус круга"),
                (new Action(() =>
                {
                    Circle circle = (Circle)figure;
                    Console.WriteLine($"Площадь круга: " +
                        $"{Math.Round(figure.Area, RoundNumber)}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Нажмите любую кнопку для продолжения");
                    Console.ReadKey();
                    Console.WriteLine(" ");
                }), "площадь круга")
            };

            var actionRectangle = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Rectangle rectangle = (Rectangle)figure;
                    Console.Write("Введите сторону А: ");
                    rectangle.SideA = CheckNumber(Console.ReadLine());

                }), "сторона А"),
                (new Action(() =>
                {
                    Rectangle rectangle = (Rectangle)figure;
                    Console.Write("Введите сторону B: ");
                    rectangle.SideB = CheckNumber(Console.ReadLine());

                }), "сторона В"),
                (new Action(() =>
                {
                    Console.WriteLine($"Площадь прямоугольника: " +
                        $"{Math.Round(figure.Area, RoundNumber)}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Нажмите любую кнопку для продолжения");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                }), "Площадь прямоугольника")
            };

            var actionTriangle = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Triangle triangle = (Triangle)figure;
                    Console.Write("Введите сторону А: ");

                    triangle.SideA = CheckNumber(Console.ReadLine());

                }), "сторона А"),
                (new Action(() =>
                {
                    Triangle triangle = (Triangle)figure;
                    Console.Write("Введите высоту А: ");
                    triangle.HeightA = CheckNumber(Console.ReadLine());


                }), "высота А"),
                (new Action(() =>
                {
                    Console.WriteLine($"Площадь треугольника:" +
                        $" {Math.Round(figure.Area, RoundNumber)}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Нажмите любую кнопку для продолжения");
                    Console.ReadKey();
                    Console.WriteLine(" ");

                }), "объема параллелепипеда")
            };

            ActionHandler(actionStart, "номера фигуры");

            var figureActionDictionary = new Dictionary<Type, List<(Action, string)>>
            {
                {typeof(Circle), actionCircle },
                {typeof(Rectangle), actionRectangle },
                {typeof(Triangle), actionTriangle },
            };

            foreach (var action in figureActionDictionary[figure.GetType()])
            {
                ActionHandler(action.Item1, action.Item2);
            }
        }

        /// <summary>
        /// Метод использования Action
        /// </summary>
        /// <param name="action"></param>
        /// <param name="propertyName"></param>
        private static void ActionHandler(Action action, string propertyName)
        {

            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (ArgumentException exception)
                {

                    Console.WriteLine($"Ошибка при вводе {propertyName}. " +
                            $"Описание ошибки: {exception.Message}");

                }
            }
        }
    }
}