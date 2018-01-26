using System;

namespace lab5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = "";

            Console.WriteLine("Would you like to roll the dice? y / n");
            input = Console.ReadLine();



            while (input.ToLower() == "y")
            {
                
            Console.WriteLine("Enter the number of sides you would like on your two dice!");
            int sides = int.Parse(Console.ReadLine());


                Random random = new Random();

                int x = random.Next(1, sides);

                int y = random.Next(1, sides);

                Console.WriteLine("Roll 1: " + x);

                Console.WriteLine("Roll 2: " + y);

                Console.WriteLine("Would you like to roll again? y/n");
                input = Console.ReadLine();
            }


                //answer == "y"



        }
    }
}
