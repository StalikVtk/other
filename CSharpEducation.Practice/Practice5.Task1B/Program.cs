using System;

namespace Practice5.Task1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager mng1 = new Manager("Manager1", 50000, 5);
            Manager mng2 = new Manager("Manager2", 50000, 6);
            Console.WriteLine("Бонус менеджера при размере команды 1-5 сотрудников: " + mng1.CalculateBonus());
            Console.WriteLine("Бонус менеджера при размере команды больше 5 сотрудников: " + mng2.CalculateBonus());
            Console.ReadKey();
        }
    }
}
