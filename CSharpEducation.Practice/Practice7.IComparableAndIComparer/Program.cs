using System;
using System.Collections.Generic;

namespace Practice7.IComparableAndIComparer
{
  internal class Program
  {
    static void Main(string[] args)
    {

      List<Book> ListBooks = new List<Book>
      {
        new Book("Ведьмак 2", "Анджей Сапковский"),
        new Book("Ведьмак 1", "Анджей Сапковский"),
        new Book("Игра престолов", "Джордж Р. Р. Мартин"),
        new Book("Властелин колец", "Джон Рональд Руэл Толкин")
      };

      Console.WriteLine("Книги");
      foreach (var book in ListBooks)
      {
        Console.WriteLine(book.Title);
      }

      Console.WriteLine();
      ListBooks.Sort();

      foreach (var book in ListBooks)
      {
        Console.WriteLine(book.Title);
      }

      List<Car> ListCars = new List<Car>
      {
        new Car("Hyundai", "Tuscon"),
        new Car("Kia", "Sportage"),
        new Car("Toyota", "Rav4"),
        new Car("Honda", "CR-V")
      };

      Console.WriteLine("\nАвто");
      ListCars.Sort(new CarMakeCompare());
      foreach (var car in ListCars)
      {
        Console.WriteLine(car.Make + " " + car.Model);
      }
      Console.WriteLine();
      ListCars.Sort(new CarModelCompare());
      foreach (var car in ListCars)
      {
        Console.WriteLine(car.Make + " " + car.Model);
      }
    }
  }
}
