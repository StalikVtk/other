using System;
using System.Text;

namespace Practice2.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            float metre = 5400;
            float kilometer = metre / 1000;

            Console.Write($"В {metre} м. получается {kilometer} км.\n");
            Console.ReadKey();
        }
    }
}
