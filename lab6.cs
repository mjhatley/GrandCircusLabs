using System;

namespace lab6
{
    class MainClass
    {
            
        public static void Main(string[] args)
        {
            string response;
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            do
            {

                Console.WriteLine("Enter a word to be translated!");
                string input = Console.ReadLine();

                input = input.ToLower();



                char firstletter = input[0];

                if (isVowel(firstletter))
                {
                    input = input + "way";
                }

                else
                {

                    while (!isVowel(firstletter))
                    {
                        
                        input = input + firstletter;
                        input = input.Remove(0, 1);

                        firstletter = input[0];

                    }

                    input = input + "ay";

                }


                Console.WriteLine(input);

                Console.WriteLine("would you like to translate another word?");
                response = Console.ReadLine();
            }while(response.ToLower() == "y");


        }
        public static void PrintCharArray(char[] words)
        {
            foreach (char letter in words)
            {
                Console.WriteLine(letter);
            }
        }
        public static bool isVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char vowel in vowels)
            {
                if (c == vowel)
                {
                    return true;
                }
            }
            return false;
        }


    }






} 