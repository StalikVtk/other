using System;
using System.IO;
using System.Text;

namespace Practice6.Task1a
{
  internal class Program
  {
    const int countNumber = 3;

    static void Main(string[] args)
    {
      while (true)
      {
        try
        {
          Console.Write("Укажите путь к файлу для чтения: D:/Number.txt");
          string path = Console.ReadLine();

          path = "D:/Number.txt";

          if (!File.Exists(path))
            throw new FileNotFoundException("Ошибка! Файла по указанному пути не существует!");
          else
            Console.WriteLine("Успешно. Файл найден.");

          FileStream ReadFile = File.Open(path, FileMode.Open);

          if (ReadFile.Length > countNumber)
            throw new ArgumentException("Ошибка! В файле больше двух чисел! Или файл содержит текст!");
          else if (ReadFile.Length == 0)
            throw new ArgumentNullException("Ошибка! Файл пустой!");

          byte[] Buffer = new byte[ReadFile.Length];
          ReadFile.Read(Buffer, 0, Buffer.Length);
          int[] ReadLine = Array.ConvertAll(Encoding.Default.GetString(Buffer).Split(' '), int.Parse);

          ReadFile.Close();

          if (ReadLine[1] == 0)
            throw new DivideByZeroException("На ноль делить нельзя!");

          double rezult = (double)ReadLine[0] / ReadLine[1];
          Console.WriteLine("Результат деления: " + rezult);

        }
        catch (FileNotFoundException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
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
