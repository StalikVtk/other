using System;

namespace Practice6.Task3a
{
  internal class TooManyAttemptsException : Exception
  {
    public TooManyAttemptsException(string message) : base(message)
    { }
  }
}
