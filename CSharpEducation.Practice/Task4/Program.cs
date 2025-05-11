using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;

            Console.Write("Введите строку № 1 ");
            str1 = Console.ReadLine();

            Console.Write("Введите строку № 2 ");
            str2 = Console.ReadLine();

            Console.WriteLine($"\n{str1} {str2}");
            Console.ReadKey();
        }
    }
}
