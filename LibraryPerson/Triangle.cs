namespace Model
{
    /// <summary>
    /// Класс, представляющий список персон.
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
        /// Расчёт объёма шара
        /// </summary>
        /// <returns>volume.</returns>
        public override double Area => 0.5 * SideA * HeightA;
    }
}