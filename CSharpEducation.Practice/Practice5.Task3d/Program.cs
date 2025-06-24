using System;
using System.Collections.Generic;
namespace Practice5.Task3d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot parr = new Parrot("Kesha", 9, "Red-Green");
            Console.WriteLine(parr.MakeSound("Кеша - хороший петушок"));

            List<Animal> animals = new List<Animal>()
            { 
               new Dog("Reks", 12),
               new Cat("Pharaon", 11),
               new Parrot("Kesha", 15, "Blue")
            };
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                   Console.WriteLine(animal.Name + " " + dog.MakeSound());
                }
                else if (animal is Cat cat)
                {
                   Console.WriteLine(animal.Name + " " + cat.MakeSound());
                }
                else if (animal is Parrot par)
                {
                    Console.WriteLine(animal.Name + " " + par.MakeSound("Кеша - хороший петушок!"));
                }
            }
        }
    }
}
