using System;

namespace Practice7.IComparableAndIComparer
{
  internal class Book : IComparable<Book>
  {

    public string Title { get; }

    public string Author { get; }

    public Book(string title, string author)
    {
      this.Title = title;

      this.Author = author;
    }

    public int CompareTo(Book book)
    {
      if (book is null)
        return 1;
      return string.Compare(Title, book.Title, StringComparison.Ordinal);
    }
  }
}
