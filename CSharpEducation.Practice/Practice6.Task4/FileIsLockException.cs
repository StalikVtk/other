using System;

namespace Practice6.Task4
{
  internal class FileIsLockException : Exception
  {
    public FileIsLockException(string message) : base(message)
    { }
  }
}
