using System;

namespace Practice2.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = "";
            int height;
            char symbolInpyt;

            Console.Write("Введите высоту треугольника: ");
            height = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите символ для вставки: ");
            symbolInpyt =Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < height + 1; i++)
            {
                Console.WriteLine(symbol.PadRight(i, symbolInpyt));
            }
            Console.ReadKey();
        }
    }
}
