using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            StartCalculator();
        }


        static void StartCalculator()
        {
            string[] input;
            do
            {

                input = inputExpression();
                if (input.Length != 3)
                    break;

                double num1 = Convert.ToDouble(input[0]);
                char oper = Convert.ToChar(input[1]);
                double num2 = Convert.ToDouble(input[2]);

                Console.WriteLine("Vas unos: " + input[0] + input[1] + input[2]);
            } while (true);
        }


        static string[] inputExpression()
        {
            string input;
            do
            {
                Console.Write("Unesite izraz: ");
                input = Console.ReadLine().ToLower();
                if (input.Equals("exit") || input.Equals("kraj"))
                    return new string[1];
                string[] tokens = input.Trim().Split();
                if (tokens.Length == 3)
                    return tokens;
                Console.WriteLine("Pogresan unos! Pokusajte ponovo.\n");
            } while (true);
        }
    }
}
