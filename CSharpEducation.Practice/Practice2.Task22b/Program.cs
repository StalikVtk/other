using System;

namespace Practice2.Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 101);
            const int numberOfInput = 5;
            int countInputUser = 1;
            string message = "";
            int userInput;
            bool game = true;
            while (game)
            {
                if (numberOfInput - countInputUser < 0)
                {
                    game = false;
                    message = "Вы проиграли!";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Мы загадали число от 1 до 100, попробуйте его отгадать." + number);
                    message = $"Попытка № {countInputUser} из {numberOfInput}";
                    Console.Write(message + " Ваше число: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if (number == userInput)
                    {
                        game = false;
                        message = "Вы отгадали. Поздравляем!";
                    }
                    else 
                    {
                        Console.WriteLine(number > userInput ? $"Загаданное число больше" : $"Загаданное число меньше");
                        Console.ReadKey();
                    }
                    countInputUser++;
                }
            }
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
