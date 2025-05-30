using System;

namespace Practice3.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(5, 4);
            Point b = new Point(12, 3);
            Console.WriteLine($"Раcстояние между точками А({a.x},{a.y}) и В({b.x},{b.y}) равно " + Math.Round(Point.DistanceBetweenPoint(a,b), 2));
            Console.ReadKey();
        }
        public struct Point
        {
            public int x { get; }
            public int y { get; }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public static double DistanceBetweenPoint(Point a, Point b)
            {
                return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Sqrt(Math.Pow(b.y - a.y, 2)));
            }
        }

    }
}
