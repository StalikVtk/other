using System;

namespace Practice2.Task25
{
    internal class Program
    {
        public enum WeekDay
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            int numberDay;
            bool correctInputUser = true;
            while (correctInputUser) 
            {
                Console.Write("Введите номер дня недели. Число от 1 до 7: ");
                numberDay = Convert.ToInt32(Console.ReadLine());
                if (numberDay < 8 && numberDay > 0)
                {
                    var days = (WeekDay)numberDay;
                    correctInputUser = false;
                    Console.WriteLine($"Указанное число {numberDay} это {days}");
                }
                else
                {
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}
