using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, f, itog;

                do
                {
                    Console.Clear();
                    Console.Write("Введите число 'a': ");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                while (a < 1);

                Console.Write("Введите число 'b': ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число 'f': ");
                f = Convert.ToInt32(Console.ReadLine());

                itog = (a + b - f / a) + f * a * a - (a + b);

                Console.Write("\nРезультат выражения: " + itog);

                Console.ReadKey();
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }
        }
    }
}
