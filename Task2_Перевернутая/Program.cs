using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Перевернутая
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            foreach (string str in stringArray) 
            {
                resultString += str.Substring(0, 1).ToLower() + str.Substring(1);
            }
            string str2 = "";
            foreach (char c in resultString)
            {   
                str2 = c + str2;
            }

            Console.WriteLine(str2);
            if (str2 == resultString)
                Console.WriteLine("Строка - паллиндром");
            else
                Console.WriteLine("Строка - не паллиндром");
            Console.ReadKey();
        }
    }
}
