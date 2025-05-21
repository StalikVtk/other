using System;
using Cs = System.Console;

namespace Practice2.Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                mas[i] = rand.Next(99);
            }
            Array.Sort(mas);
            foreach (int arr in mas)
            {
                Cs.Write(arr+"\t");
            }
            Cs.WriteLine("\nРазница между максимальным и минимальным значением элемента массива: " + (mas[mas.Length - 1] - mas[0]));
            Cs.ReadKey();
        }
    }
}
