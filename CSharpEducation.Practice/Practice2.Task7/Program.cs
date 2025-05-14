using System;

namespace Practice2.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string registerString = "привет";
            string firstChar;

            firstChar = registerString.Substring(0, 1).ToUpper();
            registerString = registerString.Replace("п", firstChar);

            Console.WriteLine(registerString);
            Console.ReadKey();

        }
    }
}
