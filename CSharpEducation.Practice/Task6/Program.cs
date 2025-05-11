using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int catet1 = 10;
            int catet2 = 8;

            double hypotinuse;

            hypotinuse = Math.Sqrt((Math.Pow(catet1, 2) + Math.Pow(catet2, 2)));
            hypotinuse = Math.Round(hypotinuse, 2);

            Console.WriteLine("Гипотенуза двух катетов 'a'=10 и 'b'=8: " + hypotinuse);

            catet1 = (int)Math.Sqrt(Math.Pow(hypotinuse, 2) - Math.Pow(catet2, 2));
            Console.WriteLine($"\nКатет 'a' стороны 'b'=8 и гипотенузы={hypotinuse} равен: " + catet1);

            Console.ReadKey();
        }
    }
}
