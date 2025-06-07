using PersonLib;
using System;

namespace Practice4.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person vlad = new Person("Владислав", 34);
            Person ivan = new Person("Иван", 38);

            vlad.PrintInfoPerson();
            ivan.PrintInfoPerson();

            Console.ReadKey();
        }
    }
}
