using System;

namespace lab_2
{
    class MainClass
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello! enter any integer between 1-100");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Woah that is not a number!");
            }

            Console.WriteLine("Output:");

            if (input % 2 == 0)
            {
                Console.WriteLine("Even");
            }

            else
            {
                Console.WriteLine("Odd");
            }


            Console.WriteLine("Enter a number between 1 and 100");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Output:");


            if (input2 % 2 == 0 && input2 >= 2 && input2 <= 25)
            {
                Console.WriteLine("Even and less than 25");
            }

            else if (input2 % 2 == 0 && input2 > 25 && input2 < 61)
            {
                Console.WriteLine("even");
            }

            else if (input2 % 2 == 0 && input2 > 60)
            {

                Console.WriteLine("even");
            }

            else
            {
                Console.WriteLine("odd");
            }


            Console.WriteLine("Enter a number between 1 and 100");
            int input3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Output:");

            if (input3 % 2 == 0 && input3 >= 2 && input3 <= 25)
            {
                Console.WriteLine("Even and less than 25");
            }

            else if (input3 % 2 == 0 && input3 > 25 && input3 < 61)
            {
                Console.WriteLine("even");
            }

            else if (input3 % 2 == 0 && input3 > 60)
            {

                Console.WriteLine(input3 + " and even");
            }

            else if (input3 % 2 == 1 && input3 > 60)
            {
                Console.WriteLine(input3 + " and Odd");
            }

            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
