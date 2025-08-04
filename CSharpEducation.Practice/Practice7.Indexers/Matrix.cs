namespace Practice7.Indexers
{
  internal class Matrix
  {
    private static int[,] data = new int[,] { { 2, 4, 6 }, { 1, 3, 5 }, { 0, 4, 8 } };

    public int Columns = data.GetLength(0);

    public int Rows = data.GetLength(1);

    public int this[int indexX, int indexY]
    {
      get
      {
        return data[indexX, indexY];
      }
      set 
      {
        data[indexX, indexY] = value;
      }
    }
    public Matrix() 
    { }
  }
}
