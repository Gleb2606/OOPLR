﻿namespace Model
{
    /// <summary>
    /// Перечисление, содержащее возможные языки
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
        /// Расчёт объёма шара
        /// </summary>
        /// <returns>volume.</returns>
        public override double Area => SideA * SideB;
    }
}