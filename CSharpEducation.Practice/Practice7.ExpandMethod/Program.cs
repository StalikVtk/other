using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.ExpandMethod
{
  internal class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine(Helper.isPalindrome("Топот"));
        Console.WriteLine(Helper.isPalindrome(""));
        Console.WriteLine(Helper.ToTitleCase("привет тут я"));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
