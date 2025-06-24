using System;
namespace Practice5.Task3a
{
    internal class Dog : Animal
    {
        private const int MaxAge = 20;
        public Dog(string name, int age) : base(name, age) 
        {
            if (age > MaxAge)
            {
                throw new ArgumentOutOfRangeException(nameof(age), $"Собаки не живут больше {MaxAge} лет!");
            }
        }
    }
}
