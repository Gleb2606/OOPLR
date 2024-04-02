using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonListLibrary;

namespace PersonListLibrary
{
    /// <summary>
    /// Дочерний класс Adult (суперкласс Person).
    /// </summary>
    public class Adult : Person
    {
        /// <summary>
        /// поле серии паспорта
        /// </summary>
        private int _passportSeries;

        /// <summary>
        /// поле номера паспорта
        /// </summary>
        private int _passportNumber;

        /// <summary>
        /// поле партнера
        /// </summary>
        private Adult _partner;

        //TODO: remove +
        
        //TODO: validation + 
        /// <summary>
        /// свойство для серии паспорта
        /// </summary>
        public int PassportSeries 
        {
            get
            {
                return _passportSeries;
            }

            set
            {
                string series = value.ToString();
                if (series.Length != 4)
                {
                    throw new ArgumentOutOfRangeException
                        ("Серия паспорта должна содержать 4 цифры");
                }
                else
                {
                    _passportSeries = value;
                }
            }
        }
        
        //TODO: validation +
        /// <summary>
        /// свойство для номера паспорта
        /// </summary>
        public int PassportNumber 
        {
            get
            {
                return _passportSeries;
            }

            set
            {
                string series = value.ToString();
                if (series.Length != 6)
                {
                    throw new ArgumentOutOfRangeException
                        ("Номер паспорта должен содержать 6 цифр");
                }
                else
                {
                    _passportSeries = value;
                }
            }
        }

        /// <summary>
        /// свойство для партнера
        /// </summary>
        public Adult Partner 
        {
            get { return _partner; }
            set
            {
                _partner = value;
                if (value != null)
                {
                    value._partner = this;
                }
            }
        }

        /// <summary>
        /// свойство для места работы
        /// </summary>
        public string Job { get; set; }

        /// <summary>
        /// Свойство для поля минимальный возраст.
        /// </summary>
        public override int MinAge { get; } = 19;

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Adult() : this("Неизвестно", "Неизвестно", 19, Gender.Male,
                               1111, 111111, null, null)
        { }

        /// <summary>
        /// Конструктор. Инициализирует новый экземпляр класса Person
        /// с указанными параметрами.
        /// </summary>
        /// <param name="firstName">Имя человека.</param>
        /// <param name="lastName">Фамилия человека.</param>
        /// <param name="age">Возраст человека.</param>
        /// <param name="gender">Пол человека.</param>
        /// <param name="passportSeries">Серия паспорта.</param>
        /// <param name="passportNumber">Номер паспорта.</param>
        /// <param name="partner">Партнер.</param>
        /// <param name="job">место работы.</param>
        public Adult(string firstName, string lastName,
                     int age, Gender gender, int passportSeries,
                     int passportNumber, Adult partner, string job)
            : base(firstName, lastName, age, gender)
        {
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            Partner = partner;
            Job = job;
        }

        /// <summary>
        /// Переопределенный метод получения информации.
        /// </summary>
        /// <returns>Информация о Взрослом человеке.</returns>
        public override string GetInfo()
        {
            string info = $"{base.GetInfo()}," +
                $" Данные паспорта: {PassportSeries} {PassportNumber}, ";

            if (Job == null)
            {
                info += $"Место работы: безработный, ";
            }
            else
            {
                info += $"Место работы: {Job}, ";
            }

            if (Partner == null)
            {
                info += $"Партнер: отсутствует";
            }
            else
            {
                info += $"Партнер: {Partner.LastName} {Partner.FirstName}";
            }

            return info;
        }

        /// <summary>
        /// Метод верификации объекта Adult.
        /// </summary>
        public void AdultVerify()
        {
            Console.WriteLine("4-ый объект является взрослым");
        }
    }
}