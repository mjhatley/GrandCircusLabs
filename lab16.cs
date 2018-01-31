using System;
using System.Collections.Generic;

namespace lab16
{
    class MainClass
    { public static void primes()
        {
            string input;
                List<int> primenumbers = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };

                Console.WriteLine("Lets locate some prime numbers! \n \n This application will find you any prime, in order, from first prime number on \n Which prime number are you looking for?");
                int response = int.Parse(Console.ReadLine());

                if (response < 16)
                {
                    int prime = primenumbers[response - 1];

                    Console.WriteLine("The nubmer " + response + " prime is " + prime);

                    Console.WriteLine("Do you want to find another prime number? (y/n)");
                    input = Console.ReadLine(); 
                if (input == "y")
                    
            {
                primes();
            }
                }
                else
                {
                    Console.WriteLine("enter a number 1-15");
                   
                }



            
            
        }
        public static void Main(string[] args)
        {
            primes();
        }
    }
}
