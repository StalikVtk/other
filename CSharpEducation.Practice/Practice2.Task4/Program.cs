using System;

namespace Practice2.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = "";

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(symbol.PadRight(i, '*'));
            }
            for (int i = 0; i < 15; i++)
            {
                symbol += "*";
                Console.WriteLine(symbol.PadLeft(15));
            }
            Console.ReadKey();
        }
    }
}
