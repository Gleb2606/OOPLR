using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonListLibrary
{
    /// <summary>
    /// Класс рандомного создания Людей.
    /// </summary>
    public static class RandomPerson
    {
        /// <summary>
        /// Возвращает случайного человека с случайными параметрами.
        /// </summary>
        /// <param name="person">Человек, для которого устанавливаются параметры.</param>
        public static void SetRandomPerson(PersonBase person)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> maleNames = new List<string>()
            {
                "Густав", "Николай", "Иоганн", "Адам", "Теодор",
                "Мустафа-Кемаль", "Джон", "Билли", "Пол", "Владимир"
            };

            List<string> femaleNames = new List<string>()
            {
                "Ева", "Оксана", "Маргарита", "Анастасия", "Эдит",
                "Латифе", "Юлия", "Татьяна", "Констанция", "Джессика"
            };

            List<string> lastNames = new List<string>()
            {
                "Майринк", "Гоголь", "Гете", "Сэндлер", "Рузвельт",
                "Ататюрк", "Сильвер", "Бонс", "Атрейдес", "Харконнен"
            };

            person.Age = random.Next(person.MinAge, person.MaxAge);
            person.Gender = (Gender)random.Next(0, 2);

            switch (person.Gender)
            {
                case Gender.Male: 
                    person.FirstName = maleNames[random.Next(0, maleNames.Count)];
                    break;

                case Gender.Female:
                    person.FirstName = femaleNames[random.Next(0, femaleNames.Count)];
                    break;
            }

            person.LastName = lastNames[random.Next(0, lastNames.Count)]; 
            
        }

        /// <summary>
        /// Возвращает случайного человека с заданным полом.
        /// </summary>
        /// <param name="person">Человек, для которого устанавливаются параметры.</param>
        public static void SetRandomPerson(PersonBase person, Gender gender)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> maleNames = new List<string>()
            {
                "Густав", "Николай", "Иоганн", "Адам", "Теодор",
                "Мустафа-Кемаль", "Джон", "Билли", "Пол", "Владимир"
            };

            List<string> femaleNames = new List<string>()
            {
                "Ева", "Оксана", "Маргарита", "Анастасия", "Эдит",
                "Латифе", "Юлия", "Татьяна", "Констанция", "Джессика"
            };

            List<string> lastNames = new List<string>()
            {
                "Майринк", "Гоголь", "Гете", "Сэндлер", "Рузвельт",
                "Ататюрк", "Сильвер", "Бонс", "Атрейдес", "Харконнен"
            };

            person.Age = random.Next(person.MinAge, person.MaxAge);

            if(gender == Gender.Male) 
            {
                person.Gender = Gender.Male;
            }
            else 
            {
                person.Gender = Gender.Female;
            }

            switch (person.Gender)
            {
                case Gender.Male:
                    person.FirstName = maleNames[random.Next(0, maleNames.Count)];
                    break;

                case Gender.Female:
                    person.FirstName = femaleNames[random.Next(0, femaleNames.Count)];
                    break;
            }

            person.LastName = lastNames[random.Next(0, lastNames.Count)];

        }

        /// <summary>
        /// Возвращает случайного человека с случайными параметрами.
        /// </summary>
        /// <returns>Случайный взрослый.</returns>
        public static PersonBase GetRandomPerson()
        {
            Random random = new Random();
            PersonBase person = new Adult();
            SetRandomPerson(person);
            return person;
        }

        /// <summary>
        /// Возвращает случайного взрослого с случайными параметрами.
        /// </summary>
        /// <param name="adult">Взрослый, для которого устанавливаются параметры.</param>
        public static void SetRandomAdult(Adult adult)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> jobs = new List<string>()
            {
                "Валют-транзит", "Цесна", "General Electric", "Полюс", "СО ЕЭС",
                "Арселор Миттал", "Скат", "Turkish airlines", "НТЦ ЕЭС", "IEEE"
            };

            adult.Age = random.Next(adult.MinAge, adult.MaxAge);
            if (random.Next(0, 2) == 0) 
            {
                adult.Job = jobs[random.Next(0, jobs.Count)];
            } 
            adult.PassportSeries = random.Next(1111, 9999);
            adult.PassportNumber = random.Next(111111, 999999);
        }

        /// <summary>
        /// Возвращает случайного взрослого с случайными параметрами.
        /// </summary>
        /// <returns>Случайный взрослый.</returns>
        public static Adult GetRandomAdult()
        {
            Adult adult = new Adult();
            SetRandomPerson(adult);
            SetRandomAdult(adult);
            SetRandomPartner(adult);
            return adult;
        }

        /// <summary>
        /// Возвращает случайного взрослого с заданным полом.
        /// </summary>
        /// <returns>Случайный взрослый.</returns>
        public static Adult GetRandomAdult(Gender gender)
        {
            Adult adult = new Adult();
            SetRandomPerson(adult, gender);
            SetRandomAdult(adult);
            return adult;
        }

        /// <summary>
        /// Возвращает случайного ребенка с случайными параметрами.
        /// </summary>
        /// <param name="child">ребенок, для которого устанавливаются параметры.</param>
        public static void SetRandomChild(Child child)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> educationals = new List<string>()
            {
                "МБОУ СОШ 13", "ОКШДС 77", "Лицей 13", "Гимназия 43", "Академия 97"
            };

            child.Educational = educationals[random.Next(0, educationals.Count)];
            if (random.Next(0, 2) == 0)
            {
                Adult father = GetRandomAdult(Gender.Male);
                child.Father = father;
            }

            if (random.Next(0, 2) == 0)
            {
                Adult mother = GetRandomAdult(Gender.Female);
                child.Mother = mother;
            }
        }

        /// <summary>
        /// Возвращает случайного ребенка с случайными параметрами.
        /// </summary>
        /// <returns>Случайный ребенка.</returns>
        public static Child GetRandomChild()
        {
            Child child = new Child();
            SetRandomPerson(child);
            SetRandomChild(child);
            return child;
        }

        /// <summary>
        /// Возвращает случайного человека с случайными параметрами.
        /// </summary>
        /// <param name="adult">Взрослый, для которого устанавливается партнер.</param>
        public static void SetRandomPartner(Adult adult)
        {
            Adult partner = new Adult();
            Random random = new Random(Guid.NewGuid().GetHashCode());

            if (random.Next(0, 2) == 0)
            {
                switch (adult.Gender)
                {
                    case Gender.Male:
                        partner = GetRandomAdult(Gender.Female);
                        break;

                    case Gender.Female:
                        partner = GetRandomAdult(Gender.Male);
                        break;
                }

                adult.Partner = partner;
            }
        }
    }
}
