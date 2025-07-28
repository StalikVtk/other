using System;

namespace Practice6.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      BankScore FirstScore = new BankScore();
      decimal amount;
      while (true)
      {
        try
        {
          Console.WriteLine(FirstScore.GetAmountScore());

          if (FirstScore.Amount == 0)
          {
            Console.Write("Укажите баланс счета: ");
            if (!decimal.TryParse(Console.ReadLine(), out amount))
              throw new ArgumentException("Ошибка! Укажите числовое значение!");
            FirstScore.Amount = amount;
            Console.WriteLine(FirstScore.GetAmountScore());
          }

          Console.WriteLine(@"Выбирите действие: 
            1. Пополнить
            2. Снять");
          int SelectMenu = int.Parse(Console.ReadLine());

          Console.Write("Укажите сумму: ");
          if (!decimal.TryParse(Console.ReadLine(), out amount))
            throw new ArgumentException("Ошибка! Укажите числовое значение!");
          switch (SelectMenu)
          {
            case 1:
              FirstScore.AddAmount(amount);
              break;
            case 2:
              FirstScore.SubtractAmount(amount);
              break;
            default:
              throw new ArgumentException("Ошибка! Пункт меню указан не верно!");
          }
        }
        catch (ArgumentException ex)
        {
          Console.WriteLine(ex.Message);
        }
      }
    }
  }
}
