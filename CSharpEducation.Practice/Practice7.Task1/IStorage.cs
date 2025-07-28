
namespace Practice7.Task1
{
  internal interface IStorage <T>
  {
    int Count { get; }

    void Add(T item);

    T Get(int index);

  }
}
