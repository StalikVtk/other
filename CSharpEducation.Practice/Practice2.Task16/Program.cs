using System;

namespace Practice2.Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -5;
            SignNumber(ref a);
        }
        static void SignNumber(ref int a)
        {
            a = -a;
        }
    }
}
