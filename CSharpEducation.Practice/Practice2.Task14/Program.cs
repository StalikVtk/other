using System;

namespace Practice2.Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] mas = CreateMas(size);
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                mas[i] = rand.Next(5) - 2;
                Console.Write(mas[i] + "\t");
            }
        }
        static int[] CreateMas(int n)
        {
            int[] mas = new int[n];
            return mas;
        }
    }
}
