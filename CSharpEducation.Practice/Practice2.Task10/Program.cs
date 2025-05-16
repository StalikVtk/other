using System;

namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size =int.Parse(args[0]);

            int[] mas = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                mas[i] = rand.Next(10);
                Console.Write(mas[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
