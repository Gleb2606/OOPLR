﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonListLibrary
{
    /// <summary>
    /// Класс, представляющий человека.
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Поле имени человека.
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Поле Фамилии человека.
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Поле возраста человека.
        /// </summary>
        private int _age;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public PersonBase() : this("Неизвестно", "Неизвестно", 0, Gender.Male)
        { }

        /// <summary>
        /// Конструктор. Инициализирует новый экземпляр класса Person
        /// с указанными параметрами.
        /// </summary>
        /// <param name="firstName">Имя человека.</param>
        /// <param name="lastName">Фамилия человека.</param>
        /// <param name="age">Возраст человека.</param>
        /// <param name="gender">Пол человека.</param>
        public PersonBase(string firstName, string lastName, 
            int age, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Получает или устанавливает имя человека.
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (IsValidName(value))
                {
                    _firstName = ConvertToProperCase(value);
                }
                else
                {
                    throw new ArgumentException("Имя должно содержать" +
                        " только русские или английские символы");
                }
            }
        }

        /// <summary>
        /// Получает или устанавливает фамилию человека.
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (IsValidLastName(_firstName, value))
                {
                    _lastName = ConvertToProperCase(value);
                }
                else
                {
                    throw new ArgumentException("Фамилия и имя " +
                        "должны быть написаны на одном языке");
                }
            }
        }

        /// <summary>
        /// Получает или устанавливает возраст человека.
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentException($"Возраст должен находится "+
                        $"в пределах от {MinAge} до {MaxAge}");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Получает или устанавливает пол человека.
        /// </summary>
        public Gender Gender { get; set; } 

        /// <summary>
        /// Максимальный возраст человека.
        /// </summary>
        public virtual int MaxAge { get; } = 120;

        /// <summary>
        /// Минимальный возраст человека.
        /// </summary>
        public virtual int MinAge { get; }

        /// <summary>
        /// Возвращает строковое представление информации о человеке.
        /// </summary>
        /// <returns>Строковое представление информации о человеке.</returns>
        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName}, возраст: {Age}, пол: {Gender}";
        }

        /// <summary>
        /// Проверяет, является ли введенное имя корректным.
        /// </summary>
        /// <param name="name">Имя для проверки.</param>
        /// <returns>True, если имя корректно, 
        /// в противном случае - false.</returns>
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;

            bool hasRussianLetters = false;
            bool hasEnglishLetters = false;

            foreach (char character in name)
            {
                if (char.IsLetter(character))
                {
                    if ((character >= 'а' && character <= 'я') ||
                        (character >= 'А' && character <= 'Я'))
                    {
                        if (hasEnglishLetters)
                        {
                            return false;
                        }

                        hasRussianLetters = true;
                    }
                    else if ((character >= 'a' && character <= 'z') ||
                        (character >= 'A' && character <= 'Z'))
                    {
                        if (hasRussianLetters)
                        {
                            return false;
                        }

                        hasEnglishLetters = true;
                    }
                }
                else if (character != ' ' && character != '-')
                {
                    return false;
                }

            }

            return hasRussianLetters || hasEnglishLetters;
        }

        /// <summary>
        /// Определяет язык, на котором написано имя, основываясь на его символах.
        /// </summary>
        /// <param name="name">Имя для определения языка.</param>
        /// <returns>Язык, на котором написано имя (русский или английский).</returns>
        /// <exception cref="FormatException">Выбрасывается, если имя пусто
        /// или содержит только пробелы.</exception>
        public static Language DetectLanguage(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new FormatException(
                    "Имя не должно быть пустым" +
                    " или содержать только пробелы.");
            }

            return name.Any(c => char.IsLetter(c) 
              && ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))) 
                ? Language.English 
                : Language.Russian;
        }

        /// <summary>
        /// Проверяет корректность фамилии с учетом языка, на котором написано имя
        /// </summary>
        /// <param name="name">Имя, на основе которого определяется язык.</param>
        /// <param name="lastName">Фамилия для проверки.</param>
        /// <returns>True, если фамилия корректна;
        /// в противном случае - false.</returns>
        public static bool IsValidLastName(string name, string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName)) return false;

            Language nameLanguage = DetectLanguage(name);

            return lastName.All(c =>
                char.IsLetter(c) 
                && ((nameLanguage == Language.Russian 
                    && ((c >= 'а' && c <= 'я') 
                        || (c >= 'А' && c <= 'Я'))) 
                    || (nameLanguage == Language.English 
                        && ((c >= 'a' && c <= 'z') 
                            || (c >= 'A' && c <= 'Z'))))
                || c == ' ' 
                || c == '-');
        }

        /// <summary>
        /// Преобразует строку в правильный формат регистра 
        /// (первая буква заглавная, остальные строчные).
        /// </summary>
        /// <param name="input">Входная строка</param>
        /// <returns>Строка с правильным форматом регистра.</returns>
        public static string ConvertToProperCase(string input)
        {
            return string.Join(" ", input.Split(' ', '-', '_').Select(s =>
                char.ToUpper(s[0]) + s.Substring(1).ToLower()));
        }
    }
}