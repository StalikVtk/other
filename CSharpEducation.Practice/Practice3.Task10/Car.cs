using System;

namespace Practice3.Task10
{
    internal class Car
    {
        public string mark;
        public Car(string mark)
        {
            this.mark = mark;
        }
        public static void PrintMark(Car car)
        {
            Console.WriteLine("Марка автомобиля: " + car.mark);
        }
    }
}
