using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите число № 1: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число № 2: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Число '1' больше числа '2'");
            }
            else if (a < b)
            {
                Console.WriteLine("Число '1' меньше числа '2'");
            }
            else
            {
                Console.WriteLine("Числа '1', '2' равны");
            }
                Console.ReadKey();
        }
    }
}
