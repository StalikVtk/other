using System;
using System.Collections.Generic;

namespace Practice7.IComparableAndIComparer
{
  internal class CarMakeCompare : IComparer<Car>
  {
    public int Compare(Car x, Car y)
    {
      return string.Compare(x.Model, y.Model, StringComparison.Ordinal);
    }
  }
}
