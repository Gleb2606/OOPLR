using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonListLibrary
{
    public static class RandomPerson
    {
        /// <summary>
        /// Возвращает случайного человека с случайными параметрами.
        /// </summary>
        /// <returns>Случайный человек.</returns>
        public static void SetRandomPerson(Person person)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> maleNames = new List<string>()
            {
                "Густав", "Николай", "Иоганн", "Адам", "Теодор",
                "Мустафа-Кемаль", "Джон", "Билли", "Марио", "Хавьер"
            };

            List<string> femaleNames = new List<string>()
            {
                "Ева", "Оксана", "Маргарита", "Анастасия", "Эдит",
                "Латифе", "Юлия", "Татьяна", "Констанция", "Карина"
            };

            List<string> lastNames = new List<string>()
            {
                "Майринк", "Гоголь", "Гете", "Сэндлер", "Рузвельт",
                "Ататюрк", "Сильвер", "Бонс", "Пьюзо", "Милей"
            };

            person.Age = random.Next(Person._minAge, Person._maxAge);
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
        /// Возвращает случайного человека с случайными параметрами.
        /// </summary>
        /// <returns>Случайный взрослый.</returns>
        public static Person GetRandomPerson()
        {
            Person person = new Person();
            SetRandomPerson(person);
            return person;
        }

        /// <summary>
        /// Возвращает случайного взрослого с случайными параметрами.
        /// </summary>
        /// <returns>Случайный человек.</returns>
        public static void SetRandomAdult(Adult adult)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> jobs = new List<string>()
            {
                "Валют-транзит", "Цесна", "General Electric", "Полюс", "СО ЕЭС",
                "Арселор Миттал", "Скат", "Turkish airlines", "НТЦ ЕЭС", "IEEE"
            };

            adult.Job = jobs[random.Next(0, jobs.Count)];
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
        /// Возвращает случайного ребенка с случайными параметрами.
        /// </summary>
        /// <returns>Случайный ребенка.</returns>
        public static void SetRandomChild(Child child)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> educationals = new List<string>()
            {
                "МБОУ СОШ 13", "ОКШДС 77", "Лицей 13", "Гимназия 43", "Академия 97"
            };

            child.Educational = educationals[random.Next(0, educationals.Count)];
            child.Father = GetRandomAdult();
            child.Mother = GetRandomAdult();
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
        /// <returns>Случайный взрослый.</returns>
        public static void SetRandomPartner(Adult adult)
        {
            Adult partner = new Adult();
            SetRandomPerson(partner);
            adult.Partner = partner;
        }
    }
}
