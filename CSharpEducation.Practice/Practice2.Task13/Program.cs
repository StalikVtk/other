using System;

namespace Practice2.Task13
{
    internal class Program
    {
        private static int[,] mas;
        static void Main(string[] args)
        {
            CreateMas(5, 5);
            PrintMas();
            Console.ReadKey();
        }

       public static void CreateMas(int sizeI, int sizeJ)
        {
            mas = new int[sizeI, sizeJ];
            Random rand = new Random();

            for (int i = 0; i < sizeI; i++)
            {
                for (int j = 0; j < sizeJ; j++)
                {
                    mas[i, j] = rand.Next(100) - 10;
                }
            }
        }
        static void PrintMas()
        {
            int sizeI = mas.GetUpperBound(0) + 1;
            int sizeJ = mas.Length / sizeI;

            for (int i = 0; i < sizeI; i++)
            {
                for (int j = 0; j < sizeJ; j++)
                {
                    Console.Write(mas[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
