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

        /// <summary>
        /// поле мест работы
        /// </summary>
        private string _job;

        /// <summary>
        /// свойство для серии паспорта
        /// </summary>
        public int PassportSeries { get; set; }

        /// <summary>
        /// свойство для номера паспорта
        /// </summary>
        public int PassportNumber { get; set;}

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
        /// конструктор по умолчанию
        /// </summary>
        public Adult() : this("Неизвестно", "Неизвестно", 0, Gender.Male,
                               0, 0, null, "Неизвестно")
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
            string info = $"{base.GetInfo()}, Место работы: {Job}," +
                $" Данные паспорта: {PassportSeries} {PassportNumber}, ";

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
    }
}