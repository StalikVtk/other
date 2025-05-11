using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const double numPi = Math.PI;
            int rCirle = 15;
            double sCircle;

            sCircle = numPi * Math.Pow(rCirle, 2);

            Console.WriteLine("Площадь круга с R = 15 составляет: " + Math.Round(sCircle, 2));
            Console.ReadKey();
        }
    }
}
