﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonListLibrary;

namespace PersonListLibrary
{
    /// <summary>
    /// Дочерний класс Child (суперкласс Person).
    /// </summary>
    public class Child : Person
    {
        //TODO: remove
        /// <summary>
        /// Поле отца.
        /// </summary>
        private Adult _father;

        //TODO: remove
        /// <summary>
        /// Поле матери.
        /// </summary>
        private Adult _mother;

        //TODO: remove
        /// <summary>
        /// Поле места обучения.
        /// </summary>
        private string _educational;

        /// <summary>
        /// свойство для отца
        /// </summary>
        public Adult Father { get; set; }

        /// <summary>
        /// свойство для матери
        /// </summary>
        public Adult Mother { get; set; }

        //TODO: validation
        /// <summary>
        /// свойство для места обучения
        /// </summary>
        public string Educational { get; set; }

        /// <summary>
        /// Свойство для поля минимальный возраст.
        /// </summary>
        public override int MaxAge { get; } = 19;

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Child() : this("Неизвестно", "Неизвестно", 0, Gender.Male,
                               null, null, "Неизвестно")
        { }

        /// <summary>
        /// Конструктор. Инициализирует новый экземпляр класса Person
        /// с указанными параметрами.
        /// </summary>
        /// <param name="firstName">Имя человека.</param>
        /// <param name="lastName">Фамилия человека.</param>
        /// <param name="age">Возраст человека.</param>
        /// <param name="gender">Пол человека.</param>
        /// <param name="father">Отец ребенка.</param>
        /// <param name="mother">Мать ребенка.</param>
        /// <param name="educational">Место учебы.</param>
        public Child(string firstName, string lastName,
                     int age, Gender gender, Adult father,
                     Adult mother, string educational)
            : base(firstName, lastName, age, gender)
        {
            Father = father;
            Mother = mother;
            Educational = educational;
        }

        /// <summary>
        /// Переопределенный метод получения информации о Ребенке.
        /// </summary>
        /// <returns>Информация о Ребенке.</returns>
        public override string GetInfo()
        {
            string info = $"{base.GetInfo()}, Место учебы: {Educational}, ";

            if (Mother != null)
            {
                //TODO: duplication
                info += $"Мать: {Mother.LastName} " + $"{Mother.FirstName}, ";
            }
            else
            {
                info += "Мать: нет, ";
            }

            if (Father != null)
            {
                //TODO: duplication
                info += $"Отец: {Father.LastName} " + $"{Father.FirstName}, ";
            }
            else
            {
                info += "Отец: нет";
            }

            return info;
        }
    }
}
