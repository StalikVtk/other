using System;
namespace Practice5.Task3d
{
    public class Animal
    {
        private const int MinAge = 1;
        private const int MaxAge = 99;

        private string _name;
        private int _age;
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Имя животного не должно быть пустым!");
                }
                _name = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if ((value < MinAge) || (value > MaxAge))
                {
                    throw new ArgumentOutOfRangeException($"Недопустимый возраст животного, укажите возраст от {MinAge} до {MaxAge}");
                }
                _age = value;
            }
        }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Eat()
        {
            Console.WriteLine("Животное ест.");
        }
        public void Sleep()
        {
            Console.WriteLine("Животное спит.");
        }
        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }
    }
}
