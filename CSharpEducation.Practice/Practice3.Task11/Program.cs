using System;

namespace Practice3.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Оно", "Стивен Кинг");

            Console.WriteLine(Book.PrintBook(book, out string infoBook));
            Console.ReadKey();
        }
    }
}
