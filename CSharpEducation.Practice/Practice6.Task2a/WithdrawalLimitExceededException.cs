using System;

namespace Practice6.Task2
{
  public class WithdrawalLimitExceededException : Exception
  {
    public WithdrawalLimitExceededException(string message) : base(message)
    { }
  }
}
