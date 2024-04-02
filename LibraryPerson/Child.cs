using System;
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

        //TODO: validation +
        /// <summary>
        /// свойство для места обучения
        /// </summary>
        public string Educational 
        {
            get
            {
                return _educational;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException
                        ("Введена пустая строка");
                }
                else
                {
                    _educational = value;
                }
            }
        }

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
            string father = "Нет отца";
            string mother = "Нет матери";
            if (Father != null)
            {
                father = Father.FirstName + " " + Father.LastName;
            }
            if (Mother != null)
            {
                mother = Mother.FirstName + " " + Mother.LastName;
            }

            return base.GetInfo() + $", Отец: {father}, Мать: {mother}, Школа: {Educational}";

            //TODO: duplication +

            //TODO: duplication +
        }

        /// <summary>
        /// Метод верификации объекта Child.
        /// </summary>
        public void ChildVerify() 
        {
            Console.WriteLine("4-ый объект является ребёнком");
        }
    }
}
