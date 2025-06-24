using System;
namespace Practice5.Task3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal kot = new Animal("Kot", 6);
            kot.Sleep();
            Console.WriteLine(kot.Age + " " + kot.Name);
            Dog dog = new Dog("Rich", 9);
            dog.Eat();
            Console.WriteLine(dog.Age + " " + dog.Name);
            Cat cat = new Cat("Filya", 7);
            cat.Sleep();
            Console.WriteLine(dog.Age + " " + dog.Name);
        }
    }
}
