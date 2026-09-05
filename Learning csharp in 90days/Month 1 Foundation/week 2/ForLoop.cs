using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Number of integration: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("The value of i is: " + i);
            }
          */

         Console.Write("Horizontal line: ");
         int horizontalLine = Convert.ToInt32(Console.ReadLine());
         Console.Write("Vertical line: ");
         int verticalLine = Convert.ToInt32(Console.ReadLine());

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