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

            inputUser = string.Join(" ", args);

            inputChar = inputUser.Substring(inputUser.Length - 1);

            inputUser = inputUser.Substring(0, inputUser.Length - 2);

            compareString = inputUser.Replace(inputChar, "");

            percentInString = (float)(inputUser.Length - compareString.Length) * 100 / inputUser.Length;

            Console.WriteLine("Процент вхождения символа '" + inputChar + "' в строке '" + inputUser + "'= " + Math.Round(percentInString, 2) + "%");
            Console.ReadKey();
        }
    }
}
