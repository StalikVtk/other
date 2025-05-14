using System;

namespace Practice2.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string registerString;

            Console.Write("Введите строку: ");
            registerString = Console.ReadLine().ToLower();

            Console.WriteLine("Строка в нижнем регистре: " + registerString);
            Console.ReadKey();
        }
    }
}
