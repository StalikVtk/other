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
            float centimetre = kilometer * 10000;

            Console.Write($"В {metre} м. получается {kilometer} км.\n");
            Console.Write($"В {kilometer} км. получается {centimetre} см.\n");

            float metreInSecond = 25;
            float kilometerInHour = (metreInSecond / 1000) * 3600;

            Console.Write($"{metreInSecond} м/с. равно {kilometerInHour} км/ч.\n");

            Console.ReadKey();
        }
    }
}
