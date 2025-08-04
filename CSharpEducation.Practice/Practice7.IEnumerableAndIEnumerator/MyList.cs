using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice7.IEnumerableAndIEnumerator
{
  internal class MyList : IEnumerable<int>
  {
    public List<int> Items { get; set; }

    public IEnumerator<int> GetEnumerator()
    {
      return Items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return Items.GetEnumerator();
    }

    public MyList(List<int> item)
    {
      this.Items = item;
    }
  }
}
