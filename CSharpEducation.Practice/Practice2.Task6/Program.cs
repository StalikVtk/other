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
            string inputUser = "Hello word! It's a beautiful day today";
            string compareString;
            string inputChar = "d";
            float percentInString;

            compareString = inputUser.Replace(inputChar, "");

            percentInString = (float)(inputUser.Length - compareString.Length) * 100 / inputUser.Length;

            Console.WriteLine("Процент вхождения символа 'd' в строке: " + inputUser + " = " + Math.Round(percentInString, 2) + "%");
            Console.ReadKey();
        }
    }
}
