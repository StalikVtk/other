using System;
namespace Practice5.Task3d
{
    internal class Parrot : Animal
    {
        private const int MaxAge = 60;
        private string _color;

        public string Color
        {
            get { return _color; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Попугай не может быть бесцветным!");
                }
                _color = value;
            }
        }
        public Parrot(string name, int age, string color) : base(name, age)
        {
            if (age > MaxAge)
            {
                throw new ArgumentOutOfRangeException(nameof(age), $"Попугаи не живут больше {MaxAge} лет!");
            }
            Console.WriteLine("Создан попугай");
        }
        public new string MakeSound()
        {
            return "Parrot is talking";
        }
        public string MakeSound(string soundText)
        {
            return "повторяет: " + soundText;
        }
    }
}
