using System;

namespace Practice7.IClonable
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person tima1 = new Person("Тимофей", 29);

      Person tima2 = (Person)tima1.Clone();
      tima2.Age = 31;

      Console.WriteLine(string.Join(" ", tima1.Name, tima1.Age, " лет"));
      Console.WriteLine(string.Join(" ", tima2.Name, tima2.Age, " лет"));

      Console.ReadKey();
    }
  }
}
