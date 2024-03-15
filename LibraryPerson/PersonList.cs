using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonListLibrary
{
    /// <summary>
    /// Класс, представляющий список персон.
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Поле список персон.
        /// </summary>
        private List<Person> _listPerson;

        /// <summary>
        /// Поле список персон.
        /// </summary>
        private string _nameListPerson;

        /// <summary>
        /// Инициализирует новый экземпляр класса PersonList с указанным именем списка.
        /// </summary>
        /// <param name="nameListPerson">Имя списка персон.</param>
        public PersonList(string nameListPerson)
        {
            _nameListPerson = nameListPerson;
            _listPerson = new List<Person>();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса PersonList 
        /// с указанным списком персон и именем списка.
        /// </summary>
        /// <param name="listPerson">Список персон.</param>
        /// <param name="nameListPerson">Имя списка персон.</param>
        public PersonList(List<Person> listPerson, string nameListPerson)
        {
            _nameListPerson = nameListPerson;
            _listPerson = listPerson;
        }

        /// <summary>
        /// Добавляет персону в список.
        /// </summary>
        /// <param name="person">Персона для добавления.</param>
        public void AddPersonToList(Person person)
        {
            _listPerson.Add(person);
        }

        /// <summary>
        /// Удаляет персону из списка.
        /// </summary>
        /// <param name="person">Персона для удаления.</param>
        public void RemovePersonFromList(Person person)
        {
            _listPerson.Remove(person);
        }

        /// <summary>
        /// Очищает весь список персон.
        /// </summary>
        public void ClearAll()
        {
            _listPerson.Clear();
        }

        /// <summary>
        /// Удаляет персону из списка по индексу.
        /// </summary>
        /// <param name="index">Индекс персоны для удаления.</param>
        public void ClearByIndex(int index)
        {
            _listPerson.RemoveAt(index);
        }

        /// <summary>
        /// Удаляет диапазон персон из списка по индексу начала и конца диапазона.
        /// </summary>
        /// <param name="start">Индекс начала диапазона.</param>
        /// <param name="end">Индекс конца диапазона.</param>
        public void ClearByRange(int start, int end)
        {
            _listPerson.RemoveRange(start, end);
        }

        /// <summary>
        /// Возвращает внутреннюю длину списка персон.
        /// </summary>
        /// <returns>Длина списка персон.</returns>
        public int GetLength()
        {
            return _listPerson.Count();
        }

        /// <summary>
        /// Возвращает персону по индексу в списке.
        /// </summary>
        /// <param name="index">Индекс персоны.</param>
        /// <returns>Персона по указанному индексу.</returns>
        public Person GetElementByIndex(int index)
        {
            if ((_listPerson.Count - 1) >= index && index >= 0)
            {
                return _listPerson[index];
            }
            else
            {
                throw new IndexOutOfRangeException($"Элемент" +
                    $" с индексом {index} в списке отсутствует");
            }
        }

        /// <summary>
        /// Возвращает индекс персоны в списке.
        /// </summary>
        /// <param name="person">Персона для поиска.</param>
        /// <returns>Индекс персоны в списке или -1, если не найдено.</returns>
        public int GetIndexByElement(Person person)
        {
            for (int i = 0; i <= (_listPerson.Count - 1); i++)
            {
                if (_listPerson[i] == person)
                {
                    return i;
                }
            }

            return -1; 
        }

        //TODO: rename
        /// <summary>
        /// Возвращает строковое представление информации о списке персон.
        /// </summary>
        /// <returns>Строковое представление информации о списке персон.</returns>
        public string GetInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{_nameListPerson}:");

            foreach (var person in _listPerson)
            {
                stringBuilder.AppendLine(person.GetInfo());
                //TODO: duplication +
            }

            stringBuilder.AppendLine("");

            return stringBuilder.ToString();
        }
    }
}