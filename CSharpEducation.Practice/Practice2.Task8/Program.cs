using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice2.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[3];

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"Введите число №{i+1}: ");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (mas[0] == mas[1] || mas[1] == mas[2] || mas[0] == mas[2])
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] += 5; 
                }
            }
            else
            {
                Console.WriteLine("Равных нет");
            }
        }
    }
}
