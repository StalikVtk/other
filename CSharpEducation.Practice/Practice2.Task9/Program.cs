using System;

namespace Practice2.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите размер массива: ");
            int [] inMas = CreateMas(Convert.ToInt32(Console.ReadLine()));

            PrintMas(inMas);
            Console.ReadKey();
        }
        static int[] CreateMas(int size)
        {
            int[] mas = new int[size];
            var rand = new Random();

            for (int i = 0; i < size; i++)
            {
                mas[i] = rand.Next(10);
            }
            return mas;
        }
        static void PrintMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("Ваш массив: " + mas[i] + " ");
            }
        }
    }
}