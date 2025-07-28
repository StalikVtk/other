using System;

namespace Practice6.Task3a
{
  internal class Program
  {
    const int CountInputDate = 3;
    static void Main(string[] args)
    {
      for (int i = CountInputDate; i >= 0; i--)
      {
        try
        {
          if (i < 1)
            throw new TooManyAttemptsException("Ошибка! Превышен лимит ввода!");
          Console.Write("Введите дату рождения: ");
          if (!DateTime.TryParse(Console.ReadLine(), out DateTime InputBirthDate))
            throw new ArgumentException($"Ошибка! Некорректный ввод даты рождения! Повторите ввод. Осталось попыток: {i - 1}");

          int TempAge = DateTime.Now.Year - InputBirthDate.Year;
          int UserAge = DateTime.Now.Month < InputBirthDate.Month ? TempAge - 1 : TempAge;

          if (UserAge < 18)
            throw new ArgumentException($"Ошибка! Пользователь несовершеннолетний! Повторите ввод. Осталось попыток: {i - 1}");
          Console.WriteLine("Ваш возраст: " + UserAge);
          break;
        }
        catch (TooManyAttemptsException ex)
        {
          Console.WriteLine(ex.Message);
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
}
