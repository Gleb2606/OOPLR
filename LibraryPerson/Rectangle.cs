using System;

namespace Model
{
    /// <summary>
    /// Класс прямоугольник
    /// </summary>
    public class Rectangle : FigureBase
    {
        /// <summary>
        /// Поле стороны А.
        /// </summary>
        private double _sideA;

        /// <summary>
        /// Поле стороны B.
        /// </summary>
        private double _sideB;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Rectangle()
        { }

        /// <summary>
        /// Конструктор. Инициализирует новый экземпляр класса Circle
        /// с указанными параметрами.
        /// </summary>
        /// <param sideA="sideA">Сторона А.</param>
        /// <param sideB="sideB">Сторона B.</param>
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        /// <summary>
        /// Получает или устанавливает сторну А.
        /// </summary>
        public double SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                _sideA = CheckNumber(value);
            }
        }

        /// <summary>
        /// Получает или устанавливает сторну B.
        /// </summary>
        public double SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                _sideB = CheckNumber(value);
            }
        }

        /// <summary>
        /// Тип фигуры.
        /// </summary>
        public override string FigureType
        {
            get
            {
                return $"Прямоугольник";
            }
        }

        /// <summary>
        /// Параметры.
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"A = {SideA}, B = {SideB}";
            }
        }

        /// <summary>
        /// Расчёт площади прямоугольника
        /// </summary>
        /// <returns>area.</returns>
        public override double Area => Math.Round((SideA * SideB), 2);
    }
}