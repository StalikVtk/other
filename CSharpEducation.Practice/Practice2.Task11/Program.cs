using System;

namespace Practice2.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(args[0]);
            int numberInsert = int.Parse(args[1]);
            int[] mas = new int[size];

            for (int i = 0; i < size; i++)
            {
                mas[i] = numberInsert;
                Console.Write(mas[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
