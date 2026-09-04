using System;

namespace IfElse{

    class Program {

        static void Main() {
            
            Console.Write("enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 10 || number == 1){
                Console.WriteLine("Correct...1");
            }

            else if (number == 20 || number == 2)
            {
                Console.WriteLine("Correct...2");
            }

            else
            {
                Console.WriteLine("Incorrect...");
            }

        }
    }    
}
