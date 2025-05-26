using System;

namespace Practice3.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student tima = new Student();
            tima.AverageScoreValue = 4.9;

            tima.PrintStudent();
            Console.ReadKey();
        }
    }
}
