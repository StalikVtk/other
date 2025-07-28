using System;

namespace Practice6.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Console.Write("Введите дату рождения: ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime InputBirthDate))
          throw new ArgumentException("Ошибка! Некорректный ввод даты рождения! Повторите ввод.");

        int TempAge = DateTime.Now.Year - InputBirthDate.Year;
        int UserAge = DateTime.Now.Month < InputBirthDate.Month ? TempAge - 1 : TempAge;

        if (UserAge < 18)
          throw new ArgumentException("Ошибка! Пользователь несовершеннолетний!");
        Console.WriteLine("Ваш возраст: " + UserAge);
      }
      catch (ArgumentException ex)
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
