using System;

namespace Practice6.Task2
{
  public class BankScore
  {
    #region Свойства

    private decimal amount;

    #endregion

    #region Поля

    public decimal Amount
    {
      get { return amount; }

      set { this.amount = value; }
    }

    #endregion

    #region Методы

    public void AddAmount(decimal amount)
    {
      this.amount += amount;
    }

    public virtual void SubtractAmount(decimal amount)
    {
      if (amount < 0)
        throw new ArgumentException("Ошибка! Сумма для снятия не может быть отрицательной!");
      else if (this.amount < amount)
        throw new ArgumentException("Ошибка! На счете не достаточно средств!");
      this.amount -= amount;
    }

    public string GetAmountScore()
    {
      return "Баланс: " + Amount;
    }

    #endregion

    #region Конструктор
    public BankScore(decimal amount = 0)
    {
      Amount = amount;
    }
    #endregion
  }
}
