using System.Collections.Generic;
using System.Linq;

namespace Practice7.Task1
{
  internal class ListStorage<T> : IStorage<T>
  {
   private readonly List<T> storage = new List<T>();

    public int Count => storage.Count;

    public void Add(T item)
    {
      storage.Add(item);
    }

    public T Get(int index)
    {
      return storage.ElementAt(index);
    }
  }
}
