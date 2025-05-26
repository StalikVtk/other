using System;

namespace Practice2.Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            string message = "";
            Console.WriteLine("Введите год для определения, будет он являться высокостным или нет.");
            Console.Write("Год: ");
            year =Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 ==0))
            {
                message = "Год высокостный";
            }
            else
            {
                message = "Год не высокостный";
            }
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
