using Practice5.Task3d;
using System;
namespace Practice5.Task3d
{
    internal class Cat : Animal
    {
        private const int MaxAge = 25;
        public Cat(string name, int age) : base(name, age)
        {
            if (age > MaxAge)
            {
                throw new ArgumentOutOfRangeException(nameof(age), $"Кошки не живут больше {MaxAge} лет!");
            }
            Console.WriteLine("Создана кошка");
        }
        public override string MakeSound()
        {
            return "Мяу мяу";
        }
    }
}
