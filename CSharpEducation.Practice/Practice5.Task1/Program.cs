using System;

namespace Practice5.Task1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Рядовой сотрудник"; 
            emp.Salary = 40000;
            Manager mng = new Manager();
            mng.Name = "Менеджер";
            mng.Salary =  50000;

            Console.WriteLine("Премия рядовго сотрудника: " + emp.CalculateBonus());
            Console.WriteLine("Премия менеджера: " + mng.CalculateBonus());
            Console.ReadKey();
        }
    }
}
