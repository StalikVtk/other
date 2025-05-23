using System;

namespace Practice2.Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            int randomNumber;
            int inputUserNumber;
            Random rand = new Random();
            randomNumber = rand.Next(1,101);
            while (game)
            {
                Console.Clear();
                Console.WriteLine("Мы загадали число от 1 до 100, попробуйте его отгадать!");
                Console.Write("Ваше число: ");
                inputUserNumber = Convert.ToInt32(Console.ReadLine());
                if (randomNumber == inputUserNumber)
                {
                    game = false;
                    Console.WriteLine("Поздравляем! Вы угадали!");
                }
            }
            Console.ReadKey();
        }
    }
}
