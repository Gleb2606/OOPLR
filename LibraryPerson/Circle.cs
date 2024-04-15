﻿using System;

namespace Model
{
    /// <summary>
    /// Класс, представляющий человека.
    /// </summary>
    public class Circle : FigureBase
    {
        /// <summary>
        /// Поле радиуса.
        /// </summary>
        private double _radius;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Circle()
        { }

        /// <summary>
        /// Конструктор. Инициализирует новый экземпляр класса Circle
        /// с указанными параметрами.
        /// </summary>
        /// <param radius="radius">радиус круга.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Получает или устанавливает радиус.
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = CheckNumber(value);
            }
        }

        /// <summary>
        /// Расчёт объёма шара
        /// </summary>
        /// <returns>volume.</returns>
        public override double Area => Math.PI * Math.Pow(Radius, 2);
    }
}