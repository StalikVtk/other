using System;

namespace Practice7.IClonable
{
  internal class Rectangle : ICloneable
  {
    public int Width { get; set; }

    public int Height { get; set; }

    public object Clone()
    {
      return this.MemberwiseClone();
    }

    public Rectangle(int width, int height)
    {
      this.Width = width;

      this.Height = height;
    }
  }
}
