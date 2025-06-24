using Practice5.Task3a;
using System;

namespace Practice5.Task3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Filya", 7);
            Console.WriteLine(cat.Name + " делает " + cat.MakeSound());
            Dog dog = new Dog("Rich", 9);
            Console.WriteLine(dog.Name + " делает " + dog.MakeSound());
            Console.ReadKey();
        }
    }
}
