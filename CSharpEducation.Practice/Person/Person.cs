using System;

namespace PersonLib
{
    public class Person
    {
        private string _personName;
        private int _personAge;

        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name 
        {
            get { return _personName; }
            set
            {
                if ((value is null) || value.Length == 0)
                {
                    throw new ArgumentNullException("Имя не может быть пустым!");
                }
                else
                {
                    _personName = value;
                }
            }
        }
        public int Age
        {
            get { return _personAge; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Недопустимый возраст! Он не может быть меньше нуля!");
                }
                else if (value > 100)
                { 
                    throw new ArgumentOutOfRangeException("Недопустимый возраст! Он не может быть больше чем сто!!!");
                }
                else
                {
                    _personAge = value;
                }
            }
        }
        public void PrintInfoPerson()
        {
            Console.WriteLine("Имя: " + _personName);
            Console.WriteLine("Возраст: " + _personAge);
        }
    }
}
