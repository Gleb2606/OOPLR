using System;

namespace Model
{
    /// <summary>
    /// Перечисление, содержащее возможный пол человека.
    /// </summary>
    public abstract class FigureBase
    {
        /// <summary>
        /// Метод расчёта площади фигуры.
        /// </summary>
        /// <returns>Volume.</returns>
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