using System;

namespace lab4_
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = "";
            do
            {

                Console.WriteLine("Hello! enter an integer between 1 - 100");
                try
                {
                    long x = long.Parse(Console.ReadLine());
                    long y = 1;
                    for (int i = 1; i <= x; i++)
                    {
                        y = y * i;

                    }
                }
                catch (FormatException)
                {
                   Console.WriteLine("Incorrect input, try again.");
                    continue;
                }
                Console.WriteLine(y);

                Console.WriteLine("Continue? y/n");
                input = Console.ReadLine();

            } while (input.ToLower() == "y");
                
        }
    }
}
