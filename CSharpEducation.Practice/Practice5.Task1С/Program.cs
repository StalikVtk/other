using Practice5.Task1C;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Logger;
namespace Practice5.Task1С
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger log = new ConsoleLogger(typeof(Program));
            List<Employee> employees = new List<Employee>
            {
                new Employee("Рядовой сотрудник №1", 45000),
                new Manager("Менеджер №1", 50000, 7),
                new Contractor("Контрактный сотрудник №1", 250.5),
                new Employee("Рядовой сотрудник №2", 40000),
                new Contractor("Контрактный сотрудник №2", 250.5),
                new Manager("Менеджер №2", 50000, 5),
                new Contractor("Контрактный сотрудник №3", 260.5)
            };
            foreach (var employee in employees)
            {
                if (employee is Contractor contractor)
                {
                    Console.Write("Укажите количество отработанных часов для " + contractor.Name + ": ");
                    int hours = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Бонус для " + contractor.Name + " состовляет: " + contractor.CalculateBonus(hours));
                    log.Log("Бонус для " + contractor.Name + " состовляет: " + contractor.CalculateBonus(hours), LogLevel.Info);
                }
                else if (employee is Manager manager)
                {
                    //Console.WriteLine("Бонус для " + manager.Name + " состовляет: " + manager.CalculateBonus());
                    log.Log("Бонус для " + manager.Name + " состовляет: " + manager.CalculateBonus(), LogLevel.Info);
                }
                else
                {
                    //Console.WriteLine("Бонус для " + employee.Name + " состовляет: " + employee.CalculateBonus());
                    log.Log("Бонус для " + employee.Name + " состовляет: " + employee.CalculateBonus(), LogLevel.Debug);
                }
            }
            Console.ReadKey();
        }
    }
}
