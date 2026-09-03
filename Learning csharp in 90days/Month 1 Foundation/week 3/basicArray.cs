using System;

namespace Practice
{
    class array
    {
        static void Main()
        {
            int[] numbers = new int[5];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            Console.WriteLine("The first number is: " + numbers[0]);
            Console.WriteLine("The second number is: " + numbers[1]);
            Console.WriteLine("The third number is: " + numbers[2]);
            Console.WriteLine("The fourth number is: " + numbers[3]);
            Console.WriteLine("The fifth number is: " + numbers[4]);
        }
    }
}