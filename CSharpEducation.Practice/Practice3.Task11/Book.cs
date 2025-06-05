using System;

namespace Practice3.Task11
{
    internal class Book
    {
        public string name;
        public string author;
        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
        public static string PrintBook(Book book, out string outStr)
        {
            return outStr = "Название книги: " + book.name + ". Автор книги: " + book.author + ".";
        }
    }
}
