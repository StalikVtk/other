using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.ExpandMethod
{
  internal static class Helper
  {
    public static bool isPalindrome(this string text)
    {
      if (string.IsNullOrEmpty(text))
        return false;

      var Line = text.Trim().ToLower();

      return Line.SequenceEqual(Line.Reverse());
    }

    public static string ToTitleCase(this string text)
    {
      var line = string.Empty;
      if (string.IsNullOrEmpty(text))
        throw new ArgumentNullException("Ошибка! Строка пустая!");

      var lines = text.Split(' ');
      for (int i = 0; i < lines.Length; i++)
      {
        line +=lines[i].Substring(0, 1).ToUpper() + lines[i].Substring(1) + " ";
      }
      return line;
    }
  }
}
