using System;

namespace Lab_Number_one
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string response;
            do
            {

                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

                Console.WriteLine("Enter Length:");
                Double firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                Double secondNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Area:");
                Console.WriteLine(firstNumber * secondNumber);

                Console.WriteLine("Perimeter:");
                Console.WriteLine((2 * firstNumber) + (2 * secondNumber));


                Console.WriteLine("Continue (y/n)");
                response = Console.ReadLine();
            }
            while (response.ToLower() == "y");

            //if (Console.ReadKey().Key == ConsoleKey.N)
            return;
            Console.WriteLine(" ");



            Console.WriteLine("Enter Length:");
            Double fifthNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Width:");
            Double sixthNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area");
            Console.WriteLine(fifthNumber * sixthNumber);


            Console.WriteLine("Perimeter");
            Console.WriteLine((2 * fifthNumber) + (2 * sixthNumber));





        }
    }
}