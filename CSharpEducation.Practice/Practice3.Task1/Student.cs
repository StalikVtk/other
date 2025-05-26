using System;

namespace Practice3.Task1
{
    public class Student
    {
        public string name = "Тимофей";
        public int age = 21;

        public void PrintStudent()
        {
            Console.WriteLine("Имя студента: {0}. Возраст: {1} год." ,name,age); 
        }
    }
}
