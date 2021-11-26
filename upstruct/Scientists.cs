using System;
using System.Collections.Generic;
using System.Text;

namespace upstruct
{
    internal class Scientists
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

        public Scientists() { }
        public static bool isEqual(Scientists a, Scientists b)
        {
            return a == b ? true : false;
        }

        public Scientists(string surname, string name, string patronymic, string sex, string nationality, DateTime dataOfBirth, string academicDegree, string post, string[] homeAdress)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.sex = sex;
            this.nationality = nationality;
            this.dataOfBirth = dataOfBirth;
            this.academicDegree = academicDegree;
            this.post = post;
            this.homeAdress = homeAdress;
        }

        public static bool operator !=(Scientists a, Scientists b)
        {
            return a == b ? true : false;
        }

        public static bool operator ==(Scientists a, Scientists b)
        {
            return a == b ? true : false;
        }

        public void showStruct(Scientists scientist1)
        {
            Console.WriteLine($"ФИО: {scientist1.surname} {scientist1.name} {scientist1.patronymic}\nПол: {scientist1.sex}" +
                $"\nНациональность: {scientist1.nationality}\nДата рождения: {scientist1.dataOfBirth.ToShortDateString()}" +
                $"\nУчёная степень: {scientist1.academicDegree}\nДолжность: {scientist1.post}\nИндекс: {scientist1.homeAdress[0]}" +
                $"\nСтрана:{scientist1.homeAdress[1]}\nОбласть: {scientist1.homeAdress[2]}\nРайон: {scientist1.homeAdress[3]}" +
                $"\nГород: {scientist1.homeAdress[4]}\nУлица: {scientist1.homeAdress[5]}\nНомер дома: {scientist1.homeAdress[6]}" +
                $"\nНомер квартиры: {scientist1.homeAdress[7]}");
        }
    }
}
