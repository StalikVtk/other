using System;
using System.IO;

namespace Practice6.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        try
        {
          Console.Write("Введите путь к файлу: ");
          string PathFile = Console.ReadLine().Trim();

          if (string.IsNullOrEmpty(PathFile))
          {
            Console.WriteLine("Ошибка! Путь к файлу не задан!");
            continue;
          }

          if (!File.Exists(PathFile))
            throw new FileNotFoundException("Ошибка! Файла не существует или путь к файлу указан неверно!");

          using (StreamReader FileRead = new StreamReader(PathFile))
          {
            if (FileRead.Peek() == -1)
              throw new ArgumentException("Ошибка! Файл не содержит данных! Добавьте данные в файл!");

            string[] ReadData = FileRead.ReadLine().Split(' ');

            int[] Mas = new int[ReadData.Length];
            for (int i = 0; i < Mas.Length; i++)
            {
              if (!int.TryParse(ReadData[i], out int number))
                throw new FormatException("Ошибка! Файл содержит некорректные данные! Файл должен содержать только целые числа!");

              Mas[i] = (number);
            }
          }
        }
        catch (ArgumentException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
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
