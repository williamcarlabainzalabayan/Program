using System;

namespace Practice
{
    class Program
    {

        static void Add()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 + num2;
            Console.Write($"The result of addition is: {result}");
        }

        static void Subtract()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 - num2;
            Console.Write($"The result of subtraction is: {result}");
        }

        static void Multiply()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 * num2;
            Console.Write($"The result of multiplication is: {result}");
        }

        static void Divide()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return;
            }

            double result = num1 / num2;
            Console.Write($"The result of division is: {result}");
        }


        static void Main(string[] args)
        {
            //calculator...
            // int - integer = numbers without decimal points
            // double - numbers with decimal points
            // string - text
            // bool - true or false
            // char - single character
            // variable - a container for storing data 
            Console.WriteLine("Hello, User!");

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Choose an operation: ");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Multiply();
                    break;
                case 4:
                    Divide();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}