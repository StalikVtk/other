using System;

namespace Practice3.Task2
{
    internal class Student
    {
        public string name = "Тимофей";
        public int age = 21;
        private double averageScoreValue = 4.8;

        public double AverageScoreValue
        {
            get 
            { 
                return averageScoreValue; 
            }
            set 
            {
                if ((value > 0) && (value < 5))
                {
                   averageScoreValue = value;
                }
            }
        }

        public void PrintStudent()
        {
            Console.WriteLine($"Имя студента: {name}. Возраст: {age}. Средний бал: {averageScoreValue}.");
        }
    }
}
