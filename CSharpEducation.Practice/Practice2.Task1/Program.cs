using System;
using System.Text;

namespace Practice2.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }
            
            Console.WriteLine("\nWhile");
            
            int j = 0;
            while (j < 10)
            {
                Console.Write(j + " ");
                j++;
            }

            Console.WriteLine("\ndo While");

            do
            {
                Console.Write(j + " ");
                j--;
            }
            while (j > 0);

            Console.ReadKey();
        }
    }
}
