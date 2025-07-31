using System;
using System.Collections.Generic;

namespace Practice7.IComparableAndIComparer
{
  internal class CarModelCompare : IComparer<Car>
  {
    public int Compare(Car x, Car y)
    {
      return string.Compare(x.Make, y.Make, StringComparison.Ordinal);
    }
  }
}
