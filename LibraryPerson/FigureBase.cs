using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Абстрактный класс фигуры.
    /// </summary>
    /// [XmlInclude(typeof(Ball))]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Triangle))]
    public abstract class FigureBase
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        [DisplayName("Тип фигуры")]
        public abstract string FigureType { get; }

        /// <summary>
        /// Параметры фигуры
        /// </summary>
        [DisplayName("Параметры")]
        public virtual string Parameters { get; }

        /// <summary>
        /// Метод расчёта площади фигуры.
        /// </summary>
        /// <returns>Volume.</returns>
        [DisplayName("Площадь, м2")]
        public abstract double Area { get; }

        /// <summary>
        /// Метод проверки введёного числа.
        /// </summary>
        /// <param name="number"></param>
        /// <returns> Число.</returns>
        /// <exception cref="ArgumentException"></exception>
        protected static double CheckNumber(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Число должно быть положительным.");
            }
            else
            {
                return number;
            }
        }
    }
}