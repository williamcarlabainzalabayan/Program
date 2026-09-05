using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Number of integration: ");
            int number = 2;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("The value of i is: " + i);
            }
          */

        
         int horizontalLine = 5;
        
         int verticalLine = 5;

            for (int i = 0; i < verticalLine; i++)
                {
                    for (int j = 0; j < horizontalLine; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
       

        }
    }
}