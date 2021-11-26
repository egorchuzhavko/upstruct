using System;

namespace upstruct
{
    class Program
    {
        public struct Scientist
        {
            public string surname;
            public string name;
            public string patronymic;
            public string sex;
            public string nationality;
            public DateTime dataOfBirth;
            public string academicDegree;
            public string post;
            public string[] homeAdress;

            public static bool operator ==(Scientist a, Scientist b) { return a.Equals(b); }
            public static bool operator !=(Scientist a, Scientist b) { return !a.Equals(b); }

        }
        public static void showStruct(Scientist scientist1)
        {
            Console.WriteLine($"ФИО: {scientist1.surname} {scientist1.name} {scientist1.patronymic}\nПол: {scientist1.sex}" +
                $"\nНациональность: {scientist1.nationality}\nДата рождения: {scientist1.dataOfBirth.ToShortDateString()}" +
                $"\nУчёная степень: {scientist1.academicDegree}\nДолжность: {scientist1.post}\nИндекс: {scientist1.homeAdress[0]}" +
                $"\nСтрана:{scientist1.homeAdress[1]}\nОбласть: {scientist1.homeAdress[2]}\nРайон: {scientist1.homeAdress[3]}" +
                $"\nГород: {scientist1.homeAdress[4]}\nУлица: {scientist1.homeAdress[5]}\nНомер дома: {scientist1.homeAdress[6]}" +
                $"\nНомер квартиры: {scientist1.homeAdress[7]}");
        }
        static void Main(string[] args)
        {
            string[] mas = new string[8] { "220064", "Беларусь", "Минская область", "Октябрьский", "Минск", "Ландера", "6", "111" };
            DateTime data = new DateTime(2001, 11, 11);
            Scientist scientist1 = new Scientist();
            scientist1.surname = "Антонов";
            scientist1.name = "Антон";
            scientist1.patronymic = "Антонов";
            scientist1.sex = "Мужчина";
            scientist1.nationality = "Кавказец";
            scientist1.dataOfBirth = data;
            scientist1.academicDegree = "Доктор наук";
            scientist1.post = "Преподаватель";
            scientist1.homeAdress = mas;
            showStruct(scientist1);
            string[] mas1 = new string[8] { "220064", "Беларусь", "Минская область", "Октябрьский", "Минск", "Ландера", "22", "27" };
            DateTime data1 = new DateTime(2000, 07, 22);
            Scientist scientist2 = new Scientist();
            scientist2.surname = "Артёмов";
            scientist2.name = "Артём";
            scientist2.patronymic = "Артёмович";
            scientist2.sex = "Мужчина";
            scientist2.nationality = "Беларус";
            scientist2.dataOfBirth = data1;
            scientist2.academicDegree = "Кандидат наук";
            scientist2.post = "Учёный";
            scientist2.homeAdress = mas1;
            Console.WriteLine();
            showStruct(scientist2);
            string[] mas2 = new string[8] { "220064", "Беларусь", "Минская область", "Октябрьский", "Минск", "Казинца", "120", "566" };
            DateTime data2 = new DateTime(2000, 07, 22);
            Scientist scientist3 = new Scientist();
            scientist3.surname = "Вулкан";
            scientist3.name = "Дмитрий";
            scientist3.patronymic = "Дмитриевич";
            scientist3.sex = "Мужчина";
            scientist3.nationality = "Беларус";
            scientist3.dataOfBirth = data1;
            scientist3.academicDegree = "Кандидат наук";
            scientist3.post = "уборщик мусора";
            scientist3.homeAdress = mas2;
            Console.WriteLine();
            showStruct(scientist3);
            if(scientist1.academicDegree=="Кандидат наук")
                Console.WriteLine($"{scientist1.surname} {scientist1.name} {scientist1.patronymic} является кандидатом наук");
            else if(scientist2.academicDegree=="Кандидат наук")
                Console.WriteLine($"{scientist2.surname} {scientist2.name} {scientist2.patronymic} является кандидатом наук");
            else if(scientist3.academicDegree=="Кандидат наук")
                Console.WriteLine($"{scientist3.surname} {scientist3.name} {scientist3.patronymic} является кандидатом наук");
            else
                Console.WriteLine("Нет кандидатов наук");

            Console.WriteLine();

            Scientists s1 = new Scientists("Вулкан", "Дмитрий", "Дмитриевич", "Мужчина", "Беларус", data1, "Кандидат наук", "уборщик мусора", mas2);
            Scientists s2 = new Scientists("Вулкан", "Дмитрий", "Дмитриевич", "Мужчина", "Беларус", data1, "Кандидат наук", "уборщик мусора", mas2);
            Console.WriteLine(s1 == s2);
            Console.WriteLine(scientist1.academicDegree == scientist2.academicDegree);
        }
    }
}
