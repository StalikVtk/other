using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice7.IEnumerableAndIEnumerator
{
  internal class MyDictionary : IEnumerable<KeyValuePair<string, int>>
  {
    private readonly Dictionary<string, int> items;

    IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
    {
      return new MyDictionaryIEnumerator(items);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return new MyDictionaryIEnumerator(items);
    }

    public class MyDictionaryIEnumerator : IEnumerator<KeyValuePair<string, int>>
    {
      private readonly Dictionary<string, int> dictionary;

      private Dictionary<string, int>.Enumerator enumerator;

      public KeyValuePair<string, int> Current
      {
        get
        {
          return enumerator.Current;
        }
      }

      object IEnumerator.Current
      {
        get
        {
          return this.Current;
        }
      }

      public void Dispose()
      {

      }

      public bool MoveNext()
      {
        return enumerator.MoveNext();
      }

      public void Reset()
      {
        enumerator = dictionary.GetEnumerator();
      }

      public MyDictionaryIEnumerator(Dictionary<string, int> items)
      {
        this.dictionary = items;

        this.enumerator = items.GetEnumerator();
      }
    }

    public MyDictionary(Dictionary<string, int> items)
    {
      this.items = items;
    }
  }
}
