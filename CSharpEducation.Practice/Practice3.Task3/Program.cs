using System;

namespace Practice3.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Результат сложения чисел 5 и 10 равен " + Calculator.Add(5, 10));
            Console.WriteLine("Результат вычитания чисел 17 и 25 равен " + Calculator.Subtrcation(17, 25));
            Console.WriteLine("Результат умножения чисел 13 и 6 равен " + Calculator.Multiply(13, 6));
            Console.WriteLine("Результат деления чисел 45 и 4 равен " + Calculator.Divide(45, 4));
            
            Console.ReadKey();
        }
    }
}
