using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUser;
            string compareString;
            string inputChar;
            float percentInString;

            Console.Write("Введите строку произвольной длины: ");
            inputUser = Console.ReadLine();

            Console.Write("Введите символ: ");
            inputChar = Console.ReadLine();

            compareString = inputUser.Replace(inputChar, "");

            percentInString = (float)(inputUser.Length - compareString.Length) * 100 / inputUser.Length;

            Console.WriteLine($"Процент вхождения символа в строке: = " + Math.Round(percentInString, 2) + "%");
            Console.ReadKey();
        }
    }
}
