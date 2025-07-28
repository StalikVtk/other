using Practice6.Task2;
using System;

namespace Practice6.Task2a
{
  internal class SavingsScore : BankScore
  {
    private DateTime? lastTakeDate;

    public override void SubtractAmount(decimal amount)
    {
      if (amount < 0)
        throw new ArgumentException("Ошибка! Сумма для снятия не может быть отрицательной!");
      else if (this.Amount < amount)
        throw new ArgumentException("Ошибка! На счете не достаточно средств!");

      if (lastTakeDate.HasValue &&
          lastTakeDate.Value.Month == DateTime.Now.Month &&
          lastTakeDate.Value.Year == DateTime.Now.Year)
      {
        throw new WithdrawalLimitExceededException($"Ошибка! Снятие возможно только 1 раз в месяц. Последние снятие {lastTakeDate.Value:d}");
      }
      this.Amount -= amount;
      this.lastTakeDate = DateTime.Now;
    }

    public SavingsScore(decimal amount) : base(amount)
    { }
  }
}
