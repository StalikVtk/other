using System;
using System.Collections.Generic;

namespace Practice7.IEnumerableAndIEnumerator
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> List = new List<int> { 4, 2, 6, 8, 9 };

      MyList IntMyList = new MyList(List);

      foreach (var item in IntMyList)
      {
        Console.WriteLine(item);
      }

      Dictionary<string, int> Dictionary = new Dictionary<string, int>();

      Dictionary.Add("Первый", 1);
      Dictionary.Add("Второй", 2);
      Dictionary.Add("Третий", 3);

      MyDictionary MyDictionary = new MyDictionary(Dictionary);

      foreach (var item in MyDictionary)
      {
        Console.WriteLine(item.Key + " " +item.Value);
      }
    }
  }
}
