using System;

namespace Practice7.Indexers
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Matrix matrix = new Matrix();

      for (int i = 0; i < matrix.Columns; i++)
      {
        for (int j = 0; j < matrix.Rows; j++)
        {
          Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
      }
      Console.WriteLine(matrix[1, 1]);

      matrix[1, 1] = 10;

      Console.WriteLine(matrix[1, 1]);
    }
  }
}
