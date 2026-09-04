using System;

namespace forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = {10, 20, 30,40,50};

            foreach (int age in ages)
            {
                Console.WriteLine("The age is: " + age);
            }
        }
    }
}