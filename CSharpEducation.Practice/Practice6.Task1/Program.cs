using System;

namespace Practice6.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        try
        {
          Console.Write("Введите число 1: ");
          if (!int.TryParse(Console.ReadLine(), out int numberOne))
            throw new ArgumentOutOfRangeException("Введите число!");

          Console.Write("Введите число 2: ");
          if (!int.TryParse(Console.ReadLine(), out int numberTwo))
            throw new ArgumentOutOfRangeException("Введите число!");

          double rezult = (double)numberOne / numberTwo;
          Console.WriteLine(rezult);

          Console.ReadKey();
        }
        catch (ArgumentOutOfRangeException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
      }
    }
  }
}