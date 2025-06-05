namespace Practice4.Task1
{
    public class MathHelper
    {
        public static int AddNumber(int a, int b)
        {
            return a + b;
        }
        public static int DoubleNumber(int a, int b)
        {
            return a * b;
        }
        public static int SubtractNumber(int a, int b)
        {
            return a - b;
        }
        public static double DivNumber(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }
    }
}
