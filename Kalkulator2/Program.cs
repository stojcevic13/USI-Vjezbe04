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
            string input;
            do
            {
                Console.Write("Unesite izraz: ");
                input = Console.ReadLine().ToLower();
                if (input.Equals("exit") || input.Equals("kraj"))
                    break;
                Console.WriteLine("Vas unos: " + input);
            } while (true);
        }
    }
}
