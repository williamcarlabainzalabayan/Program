using System;

namespace simpleGradeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade (0-100):");
            string input = Console.ReadLine();
            int grade;

            if (int.TryParse(input, out grade))
            {
                if (grade >= 90)
                {
                    Console.WriteLine("You got an A!");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("You got a B!");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("You got a C!");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("You got a D!");
                }
                else
                {
                    Console.WriteLine("You got an F!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }
    }
}