using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.IComparableAndIComparer
{
  internal class Car
  {
    public string Make { get; }

    public string Model { get; }

    public Car(string make, string model)
    {
      this.Make = make;

      this.Model = model;
    }
  }
}
