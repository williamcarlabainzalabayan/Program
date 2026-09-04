using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Number of integration: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("The value of i is: " + i);
            }
        }
    }
}