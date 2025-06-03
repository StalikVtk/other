using System;

namespace Practice3.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ширину прямоугольника: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту прямоугольника: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine("\nПлощадь прямоугольника: " + Rectangle.SquareRectangle(rectangle));

            Console.ReadKey();
        }
    }
}
