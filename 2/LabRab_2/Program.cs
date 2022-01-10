using System;

namespace LabRab_2
{
    public class Programmer
    { 
        public string Name { get; set; } //имя
        public string Surname { get; set; } //фамилия
        public byte Age { get; set; } //возраст
        public byte Experience { get; set; } //стаж работы
        public string Language { get; set; } //язык на котором пишет 

        public override string ToString()
        {
            return $"Имя: {Name}\r\nФаммилия: {Surname}\r\nВозраст: {Age} лет\r\nСтаж работы: {Experience} лет\r\nПишет на {Language}";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            programmer.Name = "Вася";
            programmer.Surname = "Пупкин";
            programmer.Age = 25;
            programmer.Experience = 7;
            programmer.Language = "C#";
            Console.WriteLine(programmer.ToString());
        }
    }
}
