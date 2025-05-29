using System;

namespace Practice3.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Console.WriteLine("- " + book1.name + " " + book1.author);

            Book book2 = new Book("CLR via C#", "Джеффри Рихтер");
            Console.WriteLine("- " + book2.name + " " + book2.author);
        }
    }
}
