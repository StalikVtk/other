using Practice3.Task4;
using System;
using System.Net.Http.Headers;

namespace Practice3.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Книга 1");
            Console.WriteLine("- " + book1.name);

            Book book2 = new Book("Книга 2", "Автор");
            Console.WriteLine("- " + book2.name + " " + book2.author);

            Book book3 = new Book("Книга 3", "Автор", "2025 г.");
            Console.WriteLine("- " + book3.name + " " + book3.author +" "+book3.yearCreateBook);

            Console.ReadKey();
        }
    }
}
