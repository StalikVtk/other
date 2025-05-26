using System;

namespace Practice2.Task24
{
    internal class Program
    {
        public enum WeekDay
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            foreach (WeekDay day in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine(day);
            }
            Console.ReadKey();
        }
    }
}
