using System;

namespace Practice2.Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[10,10];
            int[] sortMas = new int[10];
            int numberDifference;
            string rezult="";
            Random rand = new Random();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.Length / mas.GetLength(0); j++)
                {
                    mas[i, j] = rand.Next(99) - 5;
                    Console.Write(mas[i, j] + "\t");
                    sortMas[j] = mas[i, j];
                }
                Array.Sort(sortMas);
                numberDifference = sortMas[sortMas.GetUpperBound(0)] - sortMas[sortMas.GetLowerBound(0)];
                rezult += "Разница максимального и минимального числа в " + (i + 1) + " строке: " + numberDifference + "\n";
                Console.WriteLine();
            }
            Console.WriteLine(rezult);
        }
    }
}
