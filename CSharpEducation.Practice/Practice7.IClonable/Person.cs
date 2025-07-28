using System;

namespace Practice7.IClonable
{
  internal class Person : ICloneable
  {
    public string Name { get; set; }

    public int Age { get; set; }

    public object Clone()
    {
      return new Person(Name, Age);
    }

    public Person(string name, int age)
    {
      this.Name = name;

      this.Age = age;
    }
  }
}
