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

            Console.WriteLine("\nFor and Input string");

            string userInput = "";
            for (j = 0; j < 3; j++)
            {
                Console.Write($"Введите слово №{j + 1}: ");
                userInput += Console.ReadLine() + " ";
            }
            Console.WriteLine("Ваша фраза: " + userInput);

            Console.WriteLine("\nWhile and Input string");
            
            userInput = "";
            j = 0;
            while (j < 3)
            {
                Console.Write($"Введите слово №{j + 1}: ");
                userInput += Console.ReadLine() + " ";
                j++;
            }
            Console.WriteLine("Ваша фраза: " + userInput);

            Console.ReadKey();
        }
    }
}
