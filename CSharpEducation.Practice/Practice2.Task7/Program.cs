using System;

namespace Practice2.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string registerString;

            Console.Write("Введите строку: ");
            registerString = Console.ReadLine().ToUpper();

            Console.WriteLine("Строка в верхнем регистре: " + registerString);
            Console.ReadKey();
        }
    }
}
