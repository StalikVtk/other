using System;

namespace Practice3.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название месяца: ");
            string nameMonth = Console.ReadLine().ToLower();
            DateTime year = DateTime.Now;

            foreach (int numberMonth in Enum.GetValues(typeof(Month)))
            {
                string name = Enum.GetName(typeof(Month), numberMonth);
                if (nameMonth == name)
                {
                    Console.WriteLine("В указанном месяце количество дней равно: " + DateTime.DaysInMonth(year.Year, numberMonth));
                }
                else
                {
                    Console.WriteLine("Ошибка! Месяц введен некорректно!");
                    break;
                }
            }
            Console.ReadLine();
        }
        public enum Month
        {
            январь = 1,
            февраль,
            март,
            апрель,
            май,
            июнь,
            июль,
            август,
            сентябрь,
            октябрь,
            ноябрь,
            декабрь
        }
    }
}
