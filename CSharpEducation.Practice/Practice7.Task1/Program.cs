using System;

namespace Practice7.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      ListStorage<int> StorageInt = new ListStorage <int>();

      StorageInt.Add(50);
      StorageInt.Add(100);
      StorageInt.Add(150);

      for (int i = 0; i < StorageInt.Count; i++)
      {
        Console.WriteLine($"Элемент под индексом {i} равен {StorageInt.Get(i)}");
      }
      Console.WriteLine($"Всего элементов: {StorageInt.Count}\n");

      ListStorage<string> StorageString = new ListStorage<string>();

      StorageString.Add("Hello");
      StorageString.Add("Word");
      StorageString.Add("and");
      StorageString.Add("C#");

      for (int i = 0; i < StorageString.Count; i++)
      {
        Console.WriteLine($"Элемент под индексом {i} равен {StorageString.Get(i)}");
      }
      Console.WriteLine($"Всего элементов: {StorageString.Count}\n");

      Console.ReadKey();
    }
  }
}
