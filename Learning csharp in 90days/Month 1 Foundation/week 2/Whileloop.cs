using System;

namespace practice
{
    class Whileloop
    {
        static void Main(string[] args)
        {
          bool userinfo = true;

          while (userinfo)
          {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello, {name}! You are {age} years old.");

            Console.Write("Enter your choice (1 for more info, 2 to exit): ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {
                userinfo = true;
            }
            else if (userChoice == 2)
            {
                userinfo = false;
                Console.WriteLine("Exiting the program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }

          }   
        }
    }
}