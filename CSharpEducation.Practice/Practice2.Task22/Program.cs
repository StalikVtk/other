using System;

namespace Practice2.Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 101);
            int countInputUser = 1;
            string message = "";
            int userInput;
            bool game = true;
            while (game)
            {
                Console.Clear();
                Console.WriteLine("Мы загадали число от 1 до 100, попробуйте его отгадать.");
                message = $"Попытка № {countInputUser}";
                Console.Write(message + " Ваше число: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                countInputUser++;

                if (number == userInput)
                {
                    game = false;
                    message = "Вы отгадали. Поздравляем!";
                }
            }
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
