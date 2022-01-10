using System;

namespace LabRab_3
{
    class EmptyStringException : Exception
    {
        public EmptyStringException() : base()
        { }
    }

    class VeryLongNumberException : Exception
    {
        public VeryLongNumberException() : base()
        { }
    }

    class Program
    {
        static double ParseString(string str)
        {
            byte maxLength = 20; //максимальная длина строки для преобразования. Соответствует значению типа long (-9223372036854775808)
            if ((str == null) || (str == string.Empty))
                throw new EmptyStringException();//"Не введено число"
            if (str.Length>maxLength)
                throw new VeryLongNumberException();//"Введено слишком длинное число"
            return double.Parse(str);
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число и нажмите Enter:");
                double first = ParseString(Console.ReadLine());
                Console.WriteLine("Введите второе число и нажмите Enter:");
                double second = ParseString(Console.ReadLine());
                Console.WriteLine(first / second);
            }
            catch (FormatException)
            {
                Console.WriteLine("ошибка преобразования");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("деление на ноль");
            }
            catch (EmptyStringException)
            {
                Console.WriteLine("Не введено число");
            }
            catch (VeryLongNumberException)
            {
                Console.WriteLine("Введено слишком длинное число");
            }
        }
    }
}
