using System;

namespace Practice2.Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите количество вводимых строк: ");
            int size =Convert.ToInt32(Console.ReadLine());
            string[] masString = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите строку №{i+1} ");
                masString[i] = Console.ReadLine();
            }
            string printString = string.Join(" ", masString);
            
            Console.Write(printString);
            Console.ReadKey();
        }
    }
}
