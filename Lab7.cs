using System;
using System.Collections;
namespace notes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string response = "";
            int input;
            Console.WriteLine("Welcome to our C# class!");

            do
            {
                Console.WriteLine("Which student would you like to learn more about? ");
                Console.WriteLine("(Enter a number 1 - 9)");


            Hashtable students = new Hashtable();
            students.Add(1, "Marshal");
            students.Add(2, "Andrew");
            students.Add(3, "Chamus");
            students.Add(4, "David");
            students.Add(5, "Aaron");
            students.Add(6, "Jonathan");
            students.Add(7, "Albert");
            students.Add(8, "Adam");
            students.Add(9, "Tommy");

            Hashtable food = new Hashtable();
            food.Add(1, "Burgers");
            food.Add(2, "Steak");
            food.Add(3, "Sushi");
            food.Add(4, "Lasagna");
            food.Add(5, "Ribeye");
            food.Add(6, "Stouts");
            food.Add(7, "Pounded potatoes with beans");
            food.Add(8, "Putine");
            food.Add(9, "Chicken Curry");

            Hashtable hometown = new Hashtable();
            hometown.Add(1, "Holland, Mi");
            hometown.Add(2, "Fremont, Mi");
            hometown.Add(3, "Zeeland, Mi");
            hometown.Add(4, "Fort Wayne, In");
            hometown.Add(5, "Hart, Mi");
            hometown.Add(6, "MiddleVille, Mi");
            hometown.Add(7, "Grand Rapids, Mi");
            hometown.Add(8, "Grand Rapids, Mi");
            hometown.Add(9, "Raleigh, NC");

                input = int.Parse(Console.ReadLine());

                while (!students.Contains(input))
                {
                    Console.WriteLine("That student does not exist. Please try again (enter a number 1-9):");
                    input = int.Parse(Console.ReadLine());
                }

                    
                
            //Console.WriteLine(students[input]);




            //Console.WriteLine("That student does not exist. Please try again. (enter a number 1-20");

                Console.WriteLine("student " + input + " is " + (students[input]) + " What would you like to know about " + (students[input]) + "? (enter hometown or Favorite food)");


                response = Console.ReadLine();

               


                if (response.ToLower() == "hometown")
                {
                    Console.WriteLine((students[input]) + " is from " + (hometown[input]) + " would you like to know more? (enter yes or no");
                    response = Console.ReadLine();

                }
               

                if (response.ToLower() == "favorite food")
                {
                    Console.WriteLine((students[input]) + "'s favorite food is " + (food[input]) + ". Would you like to know more? (enter yes or no)");
                    response = Console.ReadLine();
                }
                /*while (!hometown.Contains(response) && (!food.Contains(response)))
                {
                    Console.WriteLine("That is an incorrect entry. Please try again (hometown or favorite food):");
                    response = (Console.ReadLine());

                }
*/

            } while (response.ToLower() == "yes");

            Console.WriteLine("Thank you!");

            //Console.WriteLine("That data does not exist. Please try again. (enter hometown or faVorite food");

            ;
        }
    }
}

