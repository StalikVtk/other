using System;

namespace Practice2.Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10] { 1, 5, -4, 9, 2, -6, 7, -3, 8, -1 };

            DeleteNumberIsMas(mas, out int[] newMas, out int countElementDelete);

            Console.Write("Массив после обработки:\n");
            foreach (int arr in newMas)
            {
                Console.Write(arr+"\t");
            }
            Console.WriteLine("\nКоличество удаленных элементов из массива: " + countElementDelete);
            Console.ReadKey();
        }

        static void DeleteNumberIsMas(int[] mas, out int[] newMas,out int countElementDelete)
        {
            newMas = Array.FindAll(mas, element => element > 0);
            countElementDelete = mas.Length - newMas.Length;
        }
    }
}
