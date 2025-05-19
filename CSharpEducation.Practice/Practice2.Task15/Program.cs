using System;

namespace Practice2.Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 };
            ReverseMas(mas);
        }
        static void ReverseMas(int[] mas)
        {
            Array.Reverse(mas);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]+"\t");
            }
        }
    }
}
