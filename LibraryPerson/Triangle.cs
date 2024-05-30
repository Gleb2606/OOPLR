using System;

namespace Model
{
    /// <summary>
    /// Класс треугольник
    /// </summary>
    public class Triangle : FigureBase
    {
        /// <summary>
        /// Поле стороны А.
        /// </summary>
        private double _sideA;

        /// <summary>
        /// Поле высоты А.
        /// </summary>
        private double _heightA;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Triangle()
        { }

        /// <summary>
        /// Конструктор. Инициализирует новый экземпляр класса Circle
        /// с указанными параметрами.
        /// </summary>
        /// <param sideA="sideA">Сторона А.</param>
        /// <param heightA="heightA">Высота A.</param>
        public Triangle(double sideA, double heightA)
        {
            SideA = sideA;
            HeightA = heightA;

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
        public double HeightA
        {
            get
            {
                return _heightA;
            }
            set
            {
                _heightA = CheckNumber(value);
            }
        }

        /// <summary>
        /// Тип фигуры.
        /// </summary>
        public override string FigureType
        {
            get
            {
                return $"Треугольник";
            }
        }

        /// <summary>
        /// Параметры.
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"A = {SideA}, H = {HeightA}";
            }
        }

        /// <summary>
        /// Расчёт площади треугольника
        /// </summary>
        /// <returns>area.</returns>
        public override double Area => Math.Round((0.5 * SideA * HeightA), 2);
    }
}