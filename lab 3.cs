using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPONENTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Square and Cube Generator. \n");
            GetInput();
        }

        private static void GetInput()
        {
            Console.Write("Please enter a number between 1 - 100: ");
            int Input = int.Parse(Console.ReadLine());

            CalculateInputPower(Input, 2);
            CalculateInputPower(Input, 3);

        }

        private static void CalculateInputPower(int Input, int power)
        {
            double response;
            Console.WriteLine(string.Format("\nListing the numbers from 1 to {0} by the power of {1}: ", Input, power));

            for (int i = 1; i <= Input; i++)
            {
                response = Math.Pow(i, power);
                Console.WriteLine(string.Format("{0}^{1} = {2}", i, power, response));
            }
        }

        private static void QuitConsoleApp()
        {
            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                GetInput();
            }
        }
    }
}