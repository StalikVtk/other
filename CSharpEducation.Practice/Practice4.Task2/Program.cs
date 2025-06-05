using System;
using Practice4.Task1;

namespace Practice4.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод сложения из библиотеки MathHelper " + MathHelper.AddNumber(3, 4));
            Console.WriteLine("Метод вычитания из библиотеки MathHelper " + MathHelper.SubtractNumber(8, 4));
            Console.WriteLine("Метод умножения из библиотеки MathHelper " + MathHelper.DoubleNumber(3, 4));
            Console.WriteLine("Метод деления из библиотеки MathHelper " + MathHelper.DivNumber(12 ,3));
            Console.ReadKey();
        }
    }
}
