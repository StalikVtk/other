using System;

namespace Practice2.Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5; 
            int b = 10;

            SwapNumber(a, b);
        }
        static void SwapNumber(int a, int b)
        {
            int tmp;

            tmp = a;
            a = b;
            b = tmp;
        }
    }
}
