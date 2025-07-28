using Practice6.Task2;
using System;
using System.Collections.Generic;

namespace Practice6.Task2a
{
  internal class Program
  {
    private static List<BankScore> Scores = new List<BankScore>();
    static int NumberMenu;
    static int NumberScore;
    private static void Main(string[] args)
    {
      while (true)
      { 
        try
        {
          Console.Clear();
          Console.WriteLine($"Открытых счетов: {Scores.Count}");
          Console.WriteLine(@"Меню:
          1. Открыть обычный 
          2. Открыть накопительный
          3. Снять
          4. Пополнить");
          NumberMenu = int.Parse(Console.ReadLine());

          switch (NumberMenu)
          {
            case 1:
              Deposit deposit = new Deposit(0);
              Scores.Add(deposit);
              break;

            case 2:
              SavingsScore savingsScore = new SavingsScore(0);
              Scores.Add(savingsScore);
              break;
            case 3:
              if (Scores.Count == 0)
                break;
              ShowScore();
              GetBankScore().SubtractAmount(InputAmount());
              break;
            case 4:
              ShowScore();
              GetBankScore().AddAmount(InputAmount());
              break;
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
          Console.ReadKey();
        }
      }
    }
    public static decimal InputAmount()
    {
      Console.Write("Укажите сумму: ");
      return decimal.Parse(Console.ReadLine());
    }

    public static BankScore GetBankScore()
    {
      if (Scores.Count > 1)
      {
        Console.Write("Укажите порядковый номер счета: ");
        NumberScore = int.Parse(Console.ReadLine());
      }
      return Scores[NumberScore - 1];
    }

    public static void ShowScore()
    {
      foreach (var score in Scores)
      {
        NumberScore = Scores.IndexOf(score) + 1;
        string Message = score is Deposit ? "обычный" : "накопительный";
        Console.WriteLine($"{NumberScore}. Баланс счета {Message}: {score.Amount}");
      }
    }
  }
}
